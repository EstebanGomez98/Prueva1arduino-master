#include <ArduinoJson.hpp>
#include <ArduinoJson.h>
float valor = 0;
String inputString = "";
bool stringComplete = false;

void SerializeObject()
{
    String json;
    StaticJsonDocument<300> doc;
    valor = analogRead(A0);
    doc["id"] = 10;
    doc["titulo"] = "Prueba Arduinor";
    doc["status"] = false;
    doc["value"] = valor;

    serializeJson(doc, json);
    Serial.println(json);
}

//deserializador
void DeserializeObject()
{
    if(stringComplete)
    {
        StaticJsonDocument<300> doc;
        DeserializationError error = deserializeJson(doc, inputString);
        if (error) { return; }
    
        int id = doc["id"];
        String titulo = doc["text"];
        bool stat = doc["status"];
        float value = doc["value"];
    
        if(value == 1)
        {
            digitalWrite(13, HIGH);
            inputString = "";
        }else if(value == 0)
        {
            digitalWrite(13, LOW);
            inputString = "";
        }
    }
}

void serialEvent(){
    while(Serial.available())
    {
        char inChar = (char)Serial.read();
        if(inChar == '\n')
        {
            stringComplete = true;
        }
        else
        {
          inputString +=inChar;
        }
    }
}

void setup()
{
    Serial.begin(9600);
    pinMode(13, OUTPUT);
    digitalWrite(13, LOW);
}

void loop()
{
  SerializeObject();
  DeserializeObject();
  delay(500);
}
