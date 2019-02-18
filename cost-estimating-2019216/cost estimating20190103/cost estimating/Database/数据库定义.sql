create database cost_estimating default character set utf8;
use cost_estimating;

#负载组成表
create table loadIngredient
(
uliID int primary key not null auto_increment,
uliName varchar(20) not null
);

insert into loadIngredient values
(1,'仪表显示'),
(2,'主回路'),
(3,'控制回路'),
(4,'风机部分'),
(5,'负载部分'),
(6,'箱体'),
(7,'线材'),
(8,'其他');

#物料名称表
create table instrumentName(
uinID int primary key not null auto_increment,
insName varchar(20) not null,
uliID int not null,
constraint fk_ll_in foreign key uliID references loadIngredient(uliID)
);

insert into instrumentName values
(1,'多功能仪表',1),
(2,'电流互感器',1),
(3,'交流接触器',2),
(4,'断路器',3),
(5,'PLC',3),
(6,'触摸屏',3),
(7,'COM口',3),
(8,'中间继电器',3),
(9,'巡检仪',3),
(10,'24V电源开关',3),
(11,'指示灯',3),
(12,'蜂鸣器',3),
(13,'急停按钮',3),
(14,'带灯按钮开关',3),
(15,'风机',4),
(16,'风机开关',4),
(17,'风机接触器',4),
(18,'热继电器',4),
(19,'电容器',5),
(20,'电抗器',5),
(21,'金属管',5),
(22,'箱体',6),
(23,'木箱',6),
(24,'控制电缆线',7),
(25,'电力电缆线',7),
(26,'镀锌铜牌',8),
(27,'其他零部件',8);


#物料品牌表
create table brand_Name(
ubnID int primary key not null auto_increment,
ubnName varchar(20) not null
);

#插入数据
insert into brand_Name values 
(1,'安科瑞'),
(2,'正泰'),
(3,'施耐德'),
(4,'松下'),
(5,'威纶通'),
(6,'欧姆龙'),
(7,'明纬'),
(8,'APT'),
(9,'航达'),
(10,'德维尔'),
(11,'其他');

#物料——详情表
create table ins_desc(
uidID int primary key not null auto_increment,
uidBrand int not null,
uidType varchar(40) not null,
uidUnit varchar(10) not null,
unitCost float not null,
insNameID int not null,
constraint fk_ins_desc foreign key uidBrand references brand_Name(ubnID)
);


#插入数据
insert into ins_desc values 
(1,1,'PZ96L E/*','pcs',1000,1),
(2,2,'变化10/5'，'pcs',60,2),
(3,3,'LC1D09 三极 线圈电压AC220V','pcs',60,3),
(4,3,'LC1D18 三极 线圈电压AC220V','pcs',108,3),
(5,3,'C65-C202P','pcs',108,4),
(6,4,'AFPXHC40R',1350,5),
(7,5,'MT8071IP','pcs',600,6),
(8,11,'485通讯口','pcs',580,7),
(9,6,'MY2N-J，DC24V 含安装底座','pcs',25,8),
(10,1,'ATRM8','pcs',350,9),
(11,7,'DR-120W-24-5A','pcs',150,10),
(12,11,'其他','pcs',25,11),
(13,8,'APT AD16-22SM/r31 灯电压AC220V','pcs',25,12),
(14,8,'LA39-A1-11Z/R;一常开一常闭;Φ22','pcs',25,13),
(15,8,'绿色LA38；二常开；Φ22；电压AC220V','pcs',25,14),
(16,9,'FZL600','pcs',800,15),
(17,10,'德维尔 ADPS-08-2-N  20~300Pa','pcs',160,16),
(18,11,'LC1D09 三极 线圈电压AC220V','pcs',49.5,17),
(19,11,'LRD08C','pcs',74,18),
(20,11,'最高电压300VAC,额定电压173VAC 10.97uf±5%，长期通电，-40～+85℃','pcs',79.6,19),
(21,11,'最高电压300VAC,额定电压173VAC 21.93uf±5%，长期通电，-40～+85℃','pcs',83.9,19),
(22,11,'最高电压300VAC,额定电压173VAC 43.87uf±5%，长期通电，-40～+85℃','pcs',160,19),
(23,11,'最高电压300VAC,额定电压173VAC 2.19uf±5%，长期通电，-40～+85℃','pcs',75,19),
(24,11,'最高电压300VAC,额定电压173VAC 4.39uf±5%，长期通电，-40～+85℃','pcs',75,19),
(25,11,'单相 166var 400VAC 50Hz','pcs',98,20),
(26,11,'单相 333var 400VAC 50Hz','pcs',120,20),
(27,11,'单相 666var 400VAC 50Hz','pcs',165,20),
(28,11,'单相 33var 400VAC 50Hz','pcs',80,20),
(29,11,'单相 66var 400VAC 50Hz','pcs',98,20),
(30,11,'666.6W，454MM','pcs',35,21),
(31,11,'800* 600* 2260','pcs',6000,22),
(32,11,'900* 700* 2360','pcs',600,23),
(33,11,'1mm2 高温导线','米',1,24),
(34,11,'1.5mm2 高温导线','米',2.5,24),
(35,11,'1.5mm2 高温导线','米',1.5,25),
(36,11,'2.5mm2 高温导线','米',2.5,25),


/*#物料名称和物料详情关系表
create table ingredient_name(
inID int primary key not null auto_increment;
ingredientID int not null;
nameID int not null;
);*/
