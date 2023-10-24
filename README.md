# RabbitMQWeb.WatermarkProject
How to use RabbitMQ event notification with in memory in .Net Core 6 project? 
In this application, I developed an application to consume the watermark data to be written on the image by the publisher with a background service (consumer) and print it on the desired area of the related photo with font, font size, color, etc. features. 

In this application, "event" was used as an option to send data from the publisher. The Publisher part does not control how the sent data is processed and more than one subscriber can use this data.
