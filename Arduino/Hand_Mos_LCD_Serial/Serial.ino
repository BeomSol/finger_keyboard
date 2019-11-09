unsigned char check=0;
const char cSTX=2, cETX=3, cACK=6, sNAK=15, cCR=13, cLF=10;
String gBuff,answer;

void SerialSet(){
  Serial.begin(9600);
  Serial.setTimeout(0);
  gBuff = "";
  answer = "";
}

void SerialUpdate(){
  //=================================
  //  데이터 수신
  //=================================
  // 데이터 없으면 리턴
  if(Serial.available() <= 0) return;
  
  // 수신내용 버퍼에 추가
  gBuff += Serial.readString();
  
  // STX ~ ETX 찾기
  int ipos0 = gBuff.indexOf(cSTX);
  if(ipos0 < 0) return;
  int ipos1 = gBuff.indexOf(cETX, ipos0);
  if(ipos1 < 0) return;
  
  // STX ~ ETX 빼고 내부만 얻기
  String st = gBuff.substring(ipos0+1, ipos1);

  // gBuff 업데이트
  gBuff = gBuff.substring(ipos1 + 1);
  
  //---------------------------------
  //  Set TX
  //---------------------------------
  if (st.substring(0, 2) == "TX")
  {
    String talk;
    talk = st.substring(2,ipos1);

    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print(talk);
    Serial.print(String(cACK) + "TX" + String(cETX));
  }
  
  //---------------------------------
  //  Ask AS
  //---------------------------------
  else if (st.substring(0, 2) == "AS")
  {
    Serial.print(String(cACK) + "AS" + answer + String(cETX));
    answer = "";
  }
}

