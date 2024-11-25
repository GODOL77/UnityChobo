CREATE TABLE character (
    ch_id	 VARCHAR(20) PRIMARY KEY,     
    ch_name	 VARCHAR(50),                 
    XP		 FLOAT DEFAULT 0,         
    health 	 FLOAT,                      
    atk		 FLOAT,                      
    crc 	 FLOAT,                    
    crt 	 FLOAT,                 
    agi 	 FLOAT,               
    ch_level FLOAT DEFAULT 1,            
    cc_res 	 FLOAT,                
    res		 FLOAT                    
);

INSERT INTO character (ch_id,ch_name,XP,health,atk,def,crc,crt,agi,ch_level,cc_res,res)
VALUES('주인공','주인공',0,32,10,10,10,150,5,1,40,40);

INSERT INTO character (ch_id,ch_name,XP,health,atk,def,crc,crt,agi,ch_level,cc_res,res)
VALUES('헤스티아','헤스티아','광전사',0,25,10,0,15,150,5,1,40,55);

INSERT INTO character (ch_id,ch_name,XP,health,atk,def,crc,crt,agi,ch_level,cc_res,res)
VALUES('사이먼','사이먼','사수',0,20,13,0,10,150,5,1,25,30);

INSERT INTO character (ch_id,ch_name,XP,health,atk,def,crc,crt,agi,ch_level,cc_res,res)
VALUES('엘라','엘라','화학자',0,18,5,0,5,150,5,1,10,70);

SELECT 
    	ch_id          AS "주 고유키",
    	ch_name        AS "이름",
    	XP             AS "경험치",
 		health :: INT  AS "체력", 
    	atk            AS "공격력",
    	def            AS "방어력",
    	crc            AS "치명타확률",
    	crt            AS "치명타 데미지",
    	agi            AS "회피율",
    	ch_level       AS "캐릭터 레벨",
    	cc_res         AS "CC저항",
    	res            AS "저항"
FROM character;

-- 주인공 정보 수정 
UPDATE character
   SET ch_name		= '주인공', -- 이름
   SET XP			= '', -- 경험치
   SET health 		= '', -- 체력
   SET atk 			= '', -- 공격력
   SET def 			= '', -- 방어력
   SET crc 	 		= '', -- 치명타확률
   SET crt 			= '', -- 치명타데미지
   SET agi 	 		= '', -- 회피율
   SET ch_level 	= '', -- 레벨
   SET cc_res 	 	= '', -- CC저항
   SET res 			= '', -- 저항
 WHERE ch_id = '주인공'