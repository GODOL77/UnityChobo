DROP TABLE character;

SELECT *
FROM character;

--테이블 선언
CREATE TABLE character
(
	ch_id NUMERIC NOT NULL,
	ch_name varchar(40) NULL,
	ch_key  char(3) 	  NOT NULL,
	ch_exp  NUMERIC	  NOT NULL,
	ch_hp   NUMERIC	  NOT NULL,
	ch_atk  NUMERIC	  NOT NULL,
	ch_def  NUMERIC    NOT NULL,
	ch_critper NUMERIC NOT NULL,
	ch_critdam NUMERIC NOT NULL,
	ch_evade NUMERIC NOT NULL,
	ch_lv NUMERIC NOT NULL,
	ch_ccres NUMERIC NOT NULL,
	ch_res NUMERIC NOT NULL,
	CONSTRAINT pk_ch PRIMARY KEY (ch_key)
);


--캐릭터 테이블 입력
INSERT INTO character (ch_id,ch_name,ch_key,ch_exp,ch_hp,ch_atk,ch_def,
ch_critper,ch_critdam,ch_evade,ch_lv,ch_ccres,ch_res)
	VALUES(1,NULL,'주인공',0,32,10,10,10,150,5,1,40,40);
INSERT INTO character (ch_id,ch_name,ch_key,ch_exp,ch_hp,ch_atk,ch_def,
ch_critper,ch_critdam,ch_evade,ch_lv,ch_ccres,ch_res)
	VALUES(2,'헤스티아','광전사',0,25,10,0,15,150,5,1,40,55);
INSERT INTO character (ch_id,ch_name,ch_key,ch_exp,ch_hp,ch_atk,ch_def,
ch_critper,ch_critdam,ch_evade,ch_lv,ch_ccres,ch_res)
	VALUES(3,'사이먼','사수',0,20,13,0,10,150,5,1,25,30);
INSERT INTO character (ch_id,ch_name,ch_key,ch_exp,ch_hp,ch_atk,ch_def,
ch_critper,ch_critdam,ch_evade,ch_lv,ch_ccres,ch_res)
	VALUES(4,'엘라','화학자',0,18,5,0,5,150,5,1,10,70);

--주인공 이름 설정
UPDATE character
	SET ch_name = '입력 값'
	WHERE ch_key = '주인공'



