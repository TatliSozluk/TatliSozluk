USE TatliSozluk

create table Uye(
uyeNo int PRIMARY KEY IDENTITY(1,1), 
uyeNick varchar(25) UNIQUE NOT NULL, 
uyeMail varchar(255) UNIQUE NOT NULL,
uyeSifre CHAR(60) NOT NULL,
uyeDogTar DATE NOT NULL,	--Sonra bakýlacak deðerin formatý yanlýþ
uyeKatTar varchar(20) NOT NULL default FORMAT (getdate(), 'dd/MM/yyyy'),
uyeCins char(1) DEFAULT 'N',
)

create table Konu(    
konuNo int PRIMARY KEY IDENTITY(1,1), 
konuAd varchar(30) NOT NULL,
)

create table Baslik(
baslikNo int PRIMARY KEY IDENTITY(1,1), 
uyeNo INT NOT NULL,
konuNo INT NOT NULL,
CONSTRAINT fkb_uyeNo FOREIGN KEY (uyeNo) REFERENCES Uye(uyeNo),
CONSTRAINT fkb_konuNo FOREIGN KEY (konuNo) REFERENCES Konu(konuNo),
baslikTar varchar(20) NOT NULL default FORMAT (getdate(), 'dd/MM/yyyy  hh:mm'),
baslikAd varchar(50) NOT NULL,
)

create table Yorum(
yorumNo int PRIMARY KEY IDENTITY(1,1), 
uyeNo int NOT NULL,
baslikNo int NOT NULL,
CONSTRAINT fky_uyeNo FOREIGN KEY (uyeNo) REFERENCES Uye(uyeNo),
CONSTRAINT fky_baslikNo FOREIGN KEY (baslikNo) REFERENCES Baslik(baslikNo),
yorum varchar(3000) NOT NULL, 
yorumTar varchar(20) NOT NULL default FORMAT (getdate(), 'dd/MM/yyyy  hh:mm'),
)




