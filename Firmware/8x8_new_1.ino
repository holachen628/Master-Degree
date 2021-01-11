//BEGINS ARDUINO SKETCH

const int Cols = 8; //Define cols number ( 1 >= Cols >= 16 )
const int Rows = 8; //Define rows number 

//const int Level = 1.2; //define amplitude of signal mapping
const float factor = 2.35;    //signal amplifying factor

//declaration of the INPUT pins we will use; i is the position within the array;
//i = 0 corresponds to output 2 (questo commento mi sembra errato ??!!??)
//si deve dichiarare tanti canali analogici quante sono le colonne dichiarate sopra.
int Pin[]= {A8, A10, A11, A9, A7, A5, A3, A1}; 

//si deve dichiarare tante line di IO digitali quante righe sono dichiarate sopra
//int dPin[] = {22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 18, 19, 20, 21}; //declaration of the OUTPUT pins we will use; i is the position within the array; i = 0 corresponds to output 2
//int dPin[] = {23, 25, 27, 29, 31, 33, 32, 30, 28, 26, 24, 22};   // Pins 22-37 used to supply current to sensor
int dPin[] = {22, 24, 26, 28, 30, 32, 33, 31}; //declaration of the OUTPUT pins we will use;

int i = 0;
int j = 0;
int k = 0;
int n = 0;
int m = 0;

int sensorValue[Cols];
int msensorValue[Cols];

 
 // Define various ADC prescaler
const unsigned char PS_16 = (1 << ADPS2);
const unsigned char PS_32 = (1 << ADPS2) | (1 << ADPS0);
const unsigned char PS_64 = (1 << ADPS2) | (1 << ADPS1);
const unsigned char PS_128 = (1 << ADPS2) | (1 << ADPS1) | (1 << ADPS0);


void setup() {
  
  for (int k = Rows-1; k >= 0 ; k--) {
pinMode(dPin[k], OUTPUT);             //declaration of pin[i] as an OUTPUT
}

for (j = 0; j >= Rows-1 ; j++) {
pinMode (Pin[i], INPUT);
}
//  Serial.begin(57600);   //turn serial on
 // Serial.begin(115200);   //turn serial on
  Serial.begin(38400);   //turn serial on
//Serial.begin(9600);   //turn serial on

  // set up the ADC
  ADCSRA &= ~PS_128;  // remove bits set by Arduino library

  // you can choose a prescaler from above.
  // PS_16, PS_32, PS_64 or PS_128
  ADCSRA |= PS_16;    // set our own prescaler to 32 
}

void loop(){
  
  
//Send start pattern
//Serial.write( B10101010); //AA
//Serial.write( B01010101); //55

for (int i = Rows-1; i >= 0 ; i--) { 
                                  
  digitalWrite (dPin[i], HIGH); //turn row i on 
  
  for (int m = Cols-1; m >= 0 ; m--) {
    sensorValue[m] = analogRead (Pin[m]) * factor; //read value column m, multiply by Level
    if (sensorValue[m] < 0) {   // this is to eliminate noise
      sensorValue[m] = 0;
    }
    Serial.print(sensorValue[m]);
    Serial.print("\t");
  }
  digitalWrite (dPin[i], LOW); //turn row i off
  //Serial.println();
}
//Send end frame pattern
//Serial.write( B11110000); //F0
//Serial.write( B00001111); //0F
Serial.println ();   //print a blank line - this line is important because Processing will start a serial event only after reading this blank line. 
}

//ENDS ARDUINO SKETCH
