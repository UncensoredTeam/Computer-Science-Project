#include <SoftwareSerial.h>
#define RxD 2 // ขา Digital 2 ของ Arduino
#define TxD 3 // ขา Digital 3 ของ Arduino
SoftwareSerial XB_CH(RxD,TxD);

void setup() {
 Serial.begin(9600); // เริ่มต้น Serial ติดต่อผ่านระหว่าง คอม กับ บอร์ด Arduino ด้วย Baud rate 9600
 Serial.flush();
 pinMode(RxD,INPUT); // RX หมายถึงการรับข้อความ จึง set ค่าเป็น INPUT
 pinMode(TxD,OUTPUT); // TX หมายถึงการส่งข้อความ จึง set ค่าเป็น OUTPUT
 XB_CH.begin(9600); // เริ่มต้น Serial ติดต่อผ่านระหว่าง บอร์ด Arduino กับ Xbee Module ด้วย Baud rate 9600
 XB_CH.flush(); // Clear Buffer ของ Xbee Module
 

}

void loop() {
  int rxCount = XB_CH.available();
  if(rxCount > 0){
    byte rxPacket[rxCount];
    for(int i = 0;i < rxCount;i++){
      rxPacket[i] = XB_CH.read();
    }
    Serial.write(rxPacket,rxCount);
  }
 
  int txCount = Serial.available();
  if(txCount > 0){
    byte txPacket[txCount];
    for(int i = 0;i < txCount;i++){
      txPacket[i] = Serial.read();
    }
    XB_CH.write(txPacket,txCount);
  }
  delay(250); 
}
