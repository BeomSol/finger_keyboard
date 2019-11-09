#define thumb A4    //엄지
#define fore A3     //검지
#define middle A2   //중지
#define ring A1     //약지
#define little A0   //소지

double finger1,finger2,finger3,finger4,finger5;
int std1,std2,std3,std4,std5;
byte curState,mosState;
String mos = "", str = "";
extern String answer;

void HandSet(){
  pinMode(thumb,INPUT);
  pinMode(fore,INPUT);
  pinMode(middle,INPUT);
  pinMode(ring,INPUT);
  pinMode(little,INPUT);

  curState = 0;
  mosState = 0;
  mos.reserve(100);
  
  finger1 = 0;
  finger2 = 0;
  finger3 = 0;
  finger4 = 0;
  finger5 = 0;

  std1 = 860;
  std2 = 850;
  std3 = 830;
  std4 = 870;
  std5 = 860;
}

void GetValue(){
  int y0 = analogRead(thumb);
  int y1 = analogRead(fore);
  int y2 = analogRead(middle);
  int y3 = analogRead(ring);
  int y4 = analogRead(little);

  finger1 = 0.95*finger1 + 0.05*y0;  
  finger2 = 0.95*finger2 + 0.05*y1;  
  finger3 = 0.95*finger3 + 0.05*y2;  
  finger4 = 0.95*finger4 + 0.05*y3;  
  finger5 = 0.95*finger5 + 0.05*y4;  
}

void HandUpdate(){
  GetValue();
  
  if(finger1>std1){       //엄지
    mosState |= 1<<0;
    curState |= 1<<0;
  }
  else if(finger1<=std1)
    curState &= ~(1<<0);
    
  if(finger2>std2){       //검지
    mosState |= 1<<1;
    curState |= 1<<1;
  }
  else if(finger2<=std2)
    curState &= ~(1<<1);
    
  if(finger3>std3){       //중지
    mosState |= 1<<2;
    curState |= 1<<2;
  }
  else if(finger3<=std3)
    curState &= ~(1<<2);
    
  if(finger4>std4){       //약지
    mosState |= 1<<3;
    curState |= 1<<3;
  }
  else if(finger4<=std4)
    curState &= ~(1<<3);
    
  if(finger5>std5){       //소지
    mosState |= 1<<4;
    curState |= 1<<4;
  }
  else if(finger5<=std5)
    curState &= ~(1<<4);
    
////////////////////////////데이터 추출
  if(curState == 0 && mosState > 0){
    if(mosState == 0x1f){         //주먹 : 글자송신
      answer = str;
      answer.replace("_"," ");
      mosState = 0;
      str = "";
      mos = "";
    }
    if(mosState == 0x18){         //약+소 : 글자삭제
      mosState = 0;
      str.remove(str.length()-1);
    }
      
    if(mosState & (1<<0))
      mos += "0";
    if(mosState & (1<<1))
      mos += "1";
    if(mosState & (1<<2))
      mos += "2";
    if(mosState & (1<<3))         //약지 : 모스부호삭제
      mos.remove(mos.length()-1);
    

    LCD_Disp();
    mosState = 0;
  }
}

