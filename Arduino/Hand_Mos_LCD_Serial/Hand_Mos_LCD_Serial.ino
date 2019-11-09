void setup() {
  SerialSet();
  MosSet();
  HandSet();
  LCDSet();
}

void loop() {
  HandUpdate();
  SerialUpdate();
}


