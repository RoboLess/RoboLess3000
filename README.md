# RoboLess3000
O nosso projeto foi criado no âmbito do concurso FAQtos, ele consiste numa mão robótica capaz de ser controlada por uma placa através de radiofrequências, além da própria placa quando conectada a um computador usar reconhecimento de voz para controlar os motores.






## Ferramentas usadas
Arduino IDE

c# / .NET framework


## Como funciona o nosso protocolo

#### O protocolo é baseado na entrega de 6 bytes através de uma estrutura


#### Estrutura

**NULL** não é usado no protocolo

**UPDT** `0` se não for preciso atualizar o dedo correspondido, `1` se for preciso atualizar o dedo correspondido, cada bit do UPDT corresponde a um dedo


#### byte[0]

|bit[0]| bit[1]| bit[2]| bit[3]| bit[4]| bit[5]| bit[6]| bit[7]|  
|:-----| :-----| :-----| :-----| :-----| :-----| :-----| :-----|
| UPDT |  UPDT |  UPDT |  UPDT |  UPDT |  NULL |  NULL |  NULL |

#### byte[1]-byte[7]
Estes bytes contem o nível de força feita pelo motor, puxando o dedo, estes podem ser alterados de 0 até 255 sem causar nenhum erro, mas o certo é configurar apenas de 0 até 180 pelo simples facto de os motores serem de 180 graus


## Spreadsheet da conexão do NRF24L01
O NRF24L01 é uma placa capaz de transmitir e receber informação que em conjunto com o nosso protocolo dá vida ao projeto

**VCC** - **3.3v**

**GND** - **GND**

**Pino 8** - **CSN**

**Pino 7** - **CE**

**Pino 13** - **SCK**

**Pino 11** - **MOSI**

**Pino 12** - **MISO**

## Funcionalidades

- Controlo de uma mão robótica
- Uso do produto à distância
- Reconhecimento de voz
- Movimentos realistas trazidos pelo design e engenharia da mão
- Controlo da mão por um programa de computadorexterno



## Como funciona o programa controlador da radio
Criamos um projeto **Windows Forms C#** capaz de se conectar pelo protocolo USB ao arduino, reproduzindo sinais radio posteriormente recebidos pela mão

![RoboLess3000Programa](https://cdn.discordapp.com/attachments/920290508973146142/1106350096343367752/image.png)

Usamos o Windows para fazer o reconhecimento de voz, tal como o protocolo USB tratado pelo Kernel do Windows

## Feedback

Se você tiver algum feedback, por favor nos deixe saber por meio de roboless3000@gmail.com



## Referência

 - [Exmeplos de usar os motores](https://docs.arduino.cc/learn/electronics/servo-motors)
 - [nRF24L01](https://howtomechatronics.com/tutorials/arduino/arduino-wireless-communication-nrf24l01-tutorial/)


## Autores

- [@Gonçalo Marques](https://github.com/Maruqes)
- [@Diogo Cardoso]()
- [@Gonçalo Vilaverde]()




![Logo](https://i.ibb.co/cD1s0vD/logoESVV.jpg)


## Licença
Este projeto encontra-se sobre a licença MIT

[MIT](https://choosealicense.com/licenses/mit/)
