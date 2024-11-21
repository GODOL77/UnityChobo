CREATE TABLE character 
(
    character_name	VARCHAR(10)	NULL,
    character_ok	CHAR(9)	NOT NULL,
    character_exp	NUMERIC	NOT NULL,
    character_hp	NUMERIC	NOT NULL,
    character_atk	NUMERIC	NOT NULL,
    character_def	NUMERIC	NOT NULL,
    character_critical_p	NUMERIC	NOT NULL,
    character_critical_d	NUMERIC	NOT NULL,
    character_dodge	NUMERIC	NOT NULL,
    character_lvl	NUMERIC	NOT NULL,
    character_ccreg	NUMERIC	NOT NULL,
    character_reg	NUMERIC	NOT NULL,
    CONSTRAINT pk_character PRIMARY KEY(character_ok)
);

INSERT INTO character (character_name, character_ok, character_exp, character_hp, character_atk, character_def, character_critical_p, character_critical_d, character_dodge, character_lvl, character_ccreg, character_reg)
    VALUES(NULL, '주인공', 0, 32, 10, 10, 10, 150, 5, 1, 40, 40)

INSERT INTO character (character_name, character_ok, character_exp, character_hp, character_atk, character_def, character_critical_p, character_critical_d, character_dodge, character_lvl, character_ccreg, character_reg)
    VALUES('헤스티아', '광전사', 0, 25, 0, 15, 10, 150, 5, 1, 40, 55)

INSERT INTO character (character_name, character_ok, character_exp, character_hp, character_atk, character_def, character_critical_p, character_critical_d, character_dodge, character_lvl, character_ccreg, character_reg)
    VALUES('사이먼', '사수', 0, 20, 13, 0, 10, 150, 5, 1, 25, 30)

INSERT INTO character (character_name, character_ok, character_exp, character_hp, character_atk, character_def, character_critical_p, character_critical_d, character_dodge, character_lvl, character_ccreg, character_reg)
    VALUES('엘라', '화학자', 0, 18, 5, 0, 5, 150, 5, 1, 10, 70)

UPDATE character
	SET character_name = '닉네임'
	WHERE character_ok = '주인공'
