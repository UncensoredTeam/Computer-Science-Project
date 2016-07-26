#include <EEPROM.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <SoftReset.h>
#include <SoftwareSerial.h> // Library ที่ใช้ในการสร้าง Serial ตัวใหม่
#define RxD 2 // ขา Digital 2 ของ Arduino
#define TxD 3 // ขา Digital 3 ของ Arduino
LiquidCrystal_I2C lcd(0x27,16,2);
SoftwareSerial XB_CH(RxD,TxD); // ชื่อ Serial ของ Xbee Module set ขา 2 เป็น RX ส่วนขา 3 เป็น TX
byte Frame[] = {0x7E,0x00,0x13,0x10,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0xFE,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}; // สร้าง Frame ที่จะส่งไปให้ Coordinator 
byte sum = 0x00; // ตัวแปรไว้ คำนวณหาค่า sum
int zero;
byte temp[17];
byte packet[19];
int mark[60];
float limit;
byte satartus = 0x01; 
void setup() {
 pinMode(RxD,INPUT); // RX หมายถึงการรับข้อความ จึง set ค่าเป็น INPUT
 pinMode(TxD,OUTPUT); // TX หมายถึงการส่งข้อความ จึง set ค่าเป็น OUTPUT
 pinMode(8,OUTPUT);
 lcd.init();
 lcd.backlight();
 digitalWrite(8,HIGH);
 for(int i = 0;i < 60;i++){
  mark[i] = 0;
 } 
 for(int i = 0;i < 50;i++){
   int idx = analogRead(0);
   if(idx >= 500 && idx < 560){ 
      mark[idx - 500] += 1; 
   }
   delay(1);
 }
 int MAX = 0,index = 0;
 for(int i = 0;i < 60;i++){
  if(mark[i] > MAX){
    MAX = mark[i];
    index = i;
  }
 }
 zero = 500+index;
 if(getCurrent() != 0){
  soft_restart();
 }
 digitalWrite(8,LOW);
 lcd.setCursor(0,0);
 lcd.print("Status:");
 lcd.setCursor(0,1);
 lcd.print("Current:");
 XB_CH.begin(9600); 
 XB_CH.flush();
 EEPROM.get(0,limit);
}

void loop() {
  if(XB_CH.available() == 17){
    for(int i = 0;i < 17;i++){
      temp[i] = XB_CH.read();
    }
    if(temp[15] == 0x01){
      digitalWrite(8,LOW);
    }else if(temp[15] == 0x00){
      digitalWrite(8,HIGH);
    }else if(temp[15] == 0x03){
      soft_restart();
    } 
  }else if(XB_CH.available() == 19){
    for(int i = 0;i < 19;i++){
      packet[i] = XB_CH.read();
    }
    if(packet[15] == 0x04){
      word limcur = word(packet[16],packet[17]);
      limit = float(limcur);
      limit = limit/100.00;
      EEPROM.put(0,limit);
    }
  }else{
    XB_CH.flush();
  }
  sum = 0x00;
  float currentVal = getCurrent();
  if(currentVal > limit){
    digitalWrite(8,HIGH);
    satartus = 0x02;
    lcd.setCursor(8,0);
    lcd.print("Overload");
  }else if(satartus != 0x02 && currentVal == 0){
    satartus = 0x00;
    lcd.setCursor(8,0);
    lcd.print("Off     ");
  }else if(currentVal > 0){
    satartus = 0x01;
    lcd.setCursor(8,0);
    lcd.print("On      ");
  }
  Frame[17] = satartus;
  String disValue = String(currentVal,2);
  disValue = disValue + "A";
  lcd.setCursor(9,1);
  lcd.print(disValue);
  int val = round(currentVal*100.00);
  byte HB = highByte(val);
  byte LB = lowByte(val);
  Frame[18] = HB;
  Frame[19] = LB;
  val = round(limit*100.00);
  HB = highByte(val);
  LB = lowByte(val);
  Frame[20] = HB;
  Frame[21] = LB;
  for(int i = 3 ;i < (Frame[2]+3);i++){
    sum += Frame[i];
  }
  sum = (0xFF - sum);
  Frame[22] = sum;
  XB_CH.write(Frame,23); 
  delay(250);
}

float getCurrent(){
  int sensorValue_aux = 0;
  float valorSensor = 0;
  float valorCorrente = 0;
    for(int i=0;i<1000;i++){
    sensorValue_aux = ((analogRead(0)) - zero); 
    valorSensor += pow(sensorValue_aux,2);
    
    //delay(1);
   }
  
  valorSensor = (sqrt(valorSensor/ 1000)) * 0.004887586; 
  valorCorrente = (valorSensor/0.066); 
  if(valorCorrente <= 0.095){
    valorCorrente = 0; 
  }
 return valorCorrente;
}

