/*
 * Project Test
 * Description: amogus
 * Author: Henry
 * Date: 26/03/2021
 */


int switchPin = D2;
int prevSwitchState = 0;
int switchState = 0;

void setup() {
    pinMode(switchPin, INPUT_PULLUP);
   
}

void loop() {
    // check button
    switchState = digitalRead(switchPin);

    // LOW means button is being pushed
    if(switchState != prevSwitchState) {
        if(switchState == LOW){
            Particle.publish("Dice", "Amogus");
        }
    }
    prevSwitchState = switchState; 

    delay(500);
}
