--create DATABASE Ahtapot_Recipe

use Ahtapot_Recipe
CREATE TABLE Kullanicilar( 
   Id       INT              IDENTITY(1,1), 
   Isim     NVARCHAR (50)    NOT NULL, 
   Soyisim  NVARCHAR (50)    NOT NULL, 
   Eposta   NVARCHAR (50)    NOT NULL,
   Sifre    NVARCHAR(20)     NOT NULL,         
   PRIMARY KEY (Id));



CREATE TABLE Tarifler( 
   Id                       INT               IDENTITY(1,1), 
   YemekAdi                 NVARCHAR (100)    NOT NULL, 
   Malzemeler               NVARCHAR (500)    NOT NULL, 
   Yapilisi                 NVARCHAR (2000)   NOT NULL,
   OlusturulmaTarihi        DATETIME          NOT NULL,
   Olusturan                INT               NOT NULL,
   PRIMARY KEY (Id));