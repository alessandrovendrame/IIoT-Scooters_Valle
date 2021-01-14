<p align="center">
  <img src="/ref/logo.png?raw=true" />
</p>

# Il progetto
Si sviuppi un'applicativo che permetta lo scambio di dati tra sensori (*client*) e un server. 

Si richiede inoltre, che la comunicazione tra i dispositivi, avvenga tramite l'utilizzo di diversi protocolli, riusciendo ad adattare il codice nel migliore dei modi. 

<p align="center">
  <img src="/ref/work_toDo.jpg?raw=true" />
</p>

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
  <img src="/ref/mqttSchema.png?raw=true" />
</p>

Utilizzo del broker **test.mosquitto.org**

### Gestione messaggi da client a server
- Il server utilizza il subscribe al topic `scooter/#`
- Il client utilizza il publish al topic `scooter/ScooterId/SensorId/SensorType`

### Gestione messaggi da server a client
- Il server utilizza il publish al topic `scooter/ScooterId/SensorId/SensorType`
- Il client utilizza il subscribe al topic `scooter/ScooterId/SensorId/SensorType`



# Il team

- **Collarini** → *progettazione e sviluppo software lato **server***
- **Vendrame** → *progettazione e sviluppo software lato **client***










