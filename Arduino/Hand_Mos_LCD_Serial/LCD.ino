#include <LiquidCrystal.h>

LiquidCrystal lcd(2,3,5,6,7,8);

byte Dot[8] = {
  B00000,
  B00000,
  B00000,
  B00100,
  B01110,
  B00100,
  B00000,
  B00000
};
byte Hyphen[8] = {
  B00000,
  B00000,
  B00000,
  B00000,
  B11111,
  B00000,
  B00000,
  B00000
};

void LCDSet(){
  lcd.createChar(0,Dot);
  lcd.createChar(1,Hyphen);
  lcd.begin(16,2);
  lcd.clear();
}

void LCD_Disp(){
  lcd.clear();
  int len = mos.length();
  for(int i=0;i<len;i++){
    if(mos.charAt(i) == '1')
      lcd.write(byte(0));
    else if(mos.charAt(i) == '2')
      lcd.write(byte(1));
    else if(mos.charAt(i) == '0'){
      lcd.clear();
      mos.remove(len-1);
      Mos2Str();
      if(str.charAt(0) >= 97 && str.charAt(0) <= 122)
        str.setCharAt(0,str.charAt(0)-32);
    }
  }
  
  lcd.setCursor(0,1);
  for(int j=0;j<str.length();j++)
    lcd.write(str.charAt(j));
}

