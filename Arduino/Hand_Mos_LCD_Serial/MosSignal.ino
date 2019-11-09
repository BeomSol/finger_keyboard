int comp[] = {12,2111,2121,211,1,1121,221,1111,11,  //a~i
              1222,212,1211,22,21,222,1221,2212,121,  //j~r
              111,2,112,1112,122,2112,2122,2211,      //s~z
              22222,12222,11222,11122,11112,11111,    //0~5
              21111,22111,22211,22221,0};           //6~9, blank

void MosSet(){
  mos.reserve(20);
  str.reserve(30);
}

void Mos2Str(){
  if(mos.toInt() == comp[0])
    str += "a";
  else if(mos.toInt() == comp[1])
    str += "b";
  else if(mos.toInt() == comp[2])
    str += "c";
  else if(mos.toInt() == comp[3])
    str += "d";
  else if(mos.toInt() == comp[4])
    str += "e";
  else if(mos.toInt() == comp[5])
    str += "f";
  else if(mos.toInt() == comp[6])
    str += "g";
  else if(mos.toInt() == comp[7])
    str += "h";
  else if(mos.toInt() == comp[8])
    str += "i";
  else if(mos.toInt() == comp[9])
    str += "j";
  else if(mos.toInt() == comp[10])
    str += "k";
  else if(mos.toInt() == comp[11])
    str += "l";
  else if(mos.toInt() == comp[12])
    str += "m";
  else if(mos.toInt() == comp[13])
    str += "n";
  else if(mos.toInt() == comp[14])
    str += "o";
  else if(mos.toInt() == comp[15])
    str += "p";
  else if(mos.toInt() == comp[16])
    str += "q";
  else if(mos.toInt() == comp[17])
    str += "r";
  else if(mos.toInt() == comp[18])
    str += "s";
  else if(mos.toInt() == comp[19])
    str += "t";
  else if(mos.toInt() == comp[20])
    str += "u";
  else if(mos.toInt() == comp[21])
    str += "v";
  else if(mos.toInt() == comp[22])
    str += "w";
  else if(mos.toInt() == comp[23])
    str += "x";
  else if(mos.toInt() == comp[24])
    str += "y";
  else if(mos.toInt() == comp[25])
    str += "z";
  else if(mos.toInt() == comp[26])
    str += "0";
  else if(mos.toInt() == comp[27])
    str += "1";
  else if(mos.toInt() == comp[28])
    str += "2";
  else if(mos.toInt() == comp[29])
    str += "3";
  else if(mos.toInt() == comp[30])
    str += "4";
  else if(mos.toInt() == comp[31])
    str += "5";
  else if(mos.toInt() == comp[32])
    str += "6";
  else if(mos.toInt() == comp[33])
    str += "7";
  else if(mos.toInt() == comp[34])
    str += "8";
  else if(mos.toInt() == comp[35])
    str += "9";
  else if(mos.toInt() == comp[36])
    str += "_";

  mos = "";
}
