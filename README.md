<p align="center">
  <img src="/ref/logo.png?raw=true" />
</p>

# Indice
1. [**Il Progetto**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#il-progetto)
   - [**Client**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#client)
   - [**Server**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#server)
2. [**Protocollo HTTP**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#protocollo-http)
   - [**POST-Rilevazione**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#rilevazione-post-apidetection)
   - [**POST-Monopattino**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#monopattino--post-apiscooter)
   - [**POST-Sensore**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#sensore--post-apisensor)
   - [**Response**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#response)
3. [**Protocollo MQTT**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#protocollo-mqtt)
   - [**Gestione messaggi da client a server**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#gestione-messaggi-da-client-a-server)
   - [**Gestione messaggi da server a client**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#gestione-messaggi-da-server-a-client)
   - [**Test**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#test)
4. [**Protocollo AMQP**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#protocollo-mqtt)
   - [**Gestione messaggi da client a server**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#gestione-messaggi-da-client-a-server)
5. [**Il team**](https://github.com/alessandrovendrame/IIoT-Scooters_Valle#il-team)

# Il progetto
Si sviuppi un'applicativo che permetta lo scambio di dati tra sensori (*client*) e un server. 

Si richiede inoltre, che la comunicazione tra i dispositivi, avvenga tramite l'utilizzo di diversi protocolli, riusciendo ad adattare il codice nel migliore dei modi. 

### Client
- Creazione sensori virtuali
  - Sensore di batteria
  - Sensore di velocità
  - Sensore di posizione
  - Sensore di stato
  
- Invio delle rilevazioni al server

### Server
- Ricezione ed invio di dati
- Gestione dati con salvataggio nel database 

# Protocollo HTTP

<p align="center">
  <img src="/ref/httpSchema.png?raw=true" />
</p>

### Rilevazione (`POST /api/detection`)

**Formato JSON**

| **Nome variabile**      | **Tipo variabile**        |
|-------------------------|---------------------------|
| SensorId                | int                       |
| ScooterId               | int                       |
| SensorValue             | string                    |
| SensorType              | string                    |
| SensorDetectionDate     | DateTime                  |


### Monopattino  (`POST /api/scooter`)

**Formato JSON**

| **Nome variabile**      | **Tipo variabile**        |
|-------------------------|---------------------------|
| ScooterId               | int                       |
| Brand                   | string                    |
| Company                 | string                    |


### Sensore  (`POST /api/sensor`)

**Formato JSON**

| **Nome variabile**      | **Tipo variabile**        |
|-------------------------|---------------------------|
| SensorId                | int                       |
| SensorType              | string                    |
| SensorMesurementUnit    | string                    |


### Response 
**Formato JSON**

| **Nome variabile**      | **Tipo variabile**        |
|-------------------------|---------------------------|
| StatusCode              | int                       |
| Message                 | string                    |


# Protocollo MQTT

<p align="center">
  <img src="/ref/mqttSchema.PNG?raw=true" />
</p>

> Funzionamento del protocollo

Il protocollo MQTT, per scambiare informazioni, sfrutta un meccanismo di pubblicazione e sottoscrizione (pubblish-subscrive) di messaggi tramite un apposito message broker, in grado di gestire migliaia di client contemporaneamente.

Si tratta di un’ottima alternativa al modello client/server dove ad instaurare una connessione diretta con il server è il client .

In MQTT, se un determinato client vuole comunicare con un altro, pubblica un messaggio su un certo argomento (detto topic) sul message broker.

Il message broker ha il compito di filtrare e distribuire le comunicazioni tra pubblisher e subscriver.

Ogni client può iscriversi a molteplici topics e ogni volta che viene pubblicato un nuovo messaggio in un determinato topic, il message broker lo distribuisce a tutti i client iscritti a quel determinato topic.

### Gestione messaggi da client a server
- Il server utilizza il subscribe al topic **scooter/#**
- Il client utilizza il publish al topic **scooter/*ScooterId*/*SensorId*/*SensorType***

**BODY Messaggio**

| **Nome variabile**      | **Tipo variabile**        |
|-------------------------|---------------------------|
| SensorValue             | string                    |
| SensorDetectionDate     | DateTime                  | 

### Gestione messaggi da server a client
- Il server utilizza il publish al topic **scooter/*ScooterId*/*SensorId*/*SensorType***
- Il client utilizza il subscribe al topic **sensor/*SensorId*/status**

**BODY Messaggio**

| **Nome variabile**      | **Tipo variabile**        |
|-------------------------|---------------------------|
| Status                  | bool                      |

## **TEST**

- Server → publish su topic **sensor/1/status**
- Client → subscribe su topic **sensor/1/status**
 
 ***NOTE:***
 
  Tramite questa funzionalità è possibile andare ad attivare/disattivare un determinato sensore.

# Protocollo AMQP

<p align="center">
  <img src="/ref/amqpSchema.PNG?raw=true" />
</p>



# Il team

- [**Marco Collarini**](https://github.com/MarcoCollarini) → *progettazione e sviluppo software lato **server***
- [**Alessandro Vendrame**](https://github.com/alessandrovendrame) → *progettazione e sviluppo software lato **client***










