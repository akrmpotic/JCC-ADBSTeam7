
-- create
CREATE TABLE Hospital (
  id SERIAL primary key,
  name varchar(50) not null,
  address varchar(50) not null,
  city varchar(50) not null,
  zipcode varchar(10) not null
);


CREATE SEQUENCE doctor_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE Doctor (
  id integer primary key default nextval('doctor_id_sequence'),
  name varchar(30) not null,
  surname varchar(30) not null,
  hospital_id integer references Hospital(id) on update cascade on delete cascade,
  password varchar(64) not null
);

CREATE SEQUENCE person_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE Person (
  id integer primary key default nextval('person_id_sequence'),
  name varchar(30) not null,
  surname varchar(30) not null,
  dateOfBirth date not null,
  gender varchar(1) not null,
  password varchar(64) not null,
  person_id_father integer not null,
  person_id_mother integer not null,
  pregnancy_id integer not null,
  numberofbornchildren integer,
  CHECK (gender LIKE 'M' OR gender LIKE 'F'),
  CHECK (numberofbornchildren>=0)
);




CREATE SEQUENCE pregnancy_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE PregnancyHistory (
  id integer primary key default nextval('pregnancy_id_sequence'),
  beginningOfPregnancy date not null,
  outcome text,
  numberOfBornChildren integer,
  numberOfUnbornChildren integer,
  person_id integer references Person(id) on update cascade on delete cascade not null,
  doctor_id integer references Doctor(id) on update cascade on delete cascade not null,
  check (person_id>1)
);


CREATE SEQUENCE gynecological_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE Gynecological_examination (
  id integer primary key default nextval('gynecological_id_sequence'),
  date date not null,
  time time not null,
  diagnosis text not null,
  descript text,
  infirmary integer not null,
  doctor_id integer references Doctor(id) on update restrict on delete restrict not null,
  person_id integer references Person(id) on update restrict on delete restrict not null,
  check (person_id>1)
);


CREATE SEQUENCE CTG_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE CTG (
  id integer primary key default nextval('CTG_id_sequence'),
  date date not null,
  time time not null,
  descript text,
  infirmary integer not null,
  doctor_id integer references Doctor(id) on update restrict on delete restrict not null,
  person_id integer references Person(id) on update restrict on delete restrict not null,
  check (person_id>1)
);


CREATE SEQUENCE ultrasound_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE Ultrasound (
    id integer primary key default nextval('ultrasound_id_sequence'),
    date date not null,
    time time not null,
    infirmary integer not null,
    descript text,
    picture bytea,
    doctor_id integer references Doctor(id) on update restrict on delete restrict not null,
    person_id integer references Person(id) on update restrict on delete restrict not null,
    check (person_id>1)
);


CREATE SEQUENCE colordoopler_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE ColorDoppler (
    id integer primary key default nextval('colordoopler_id_sequence'),
    bloodFlow text,
    umbilicalArtery text,
    centralCerebraArtery text,
    fetalAorta text,
    umbilicalVein text,
    infirmary integer not null,
    doctor_id integer references Doctor(id) on update restrict on delete restrict not null,
    person_id integer references Person(id) on update restrict on delete restrict not null,
    check (person_id>1)
);


CREATE SEQUENCE incontinence_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE Incontinences (
    id integer primary key default nextval('incontinence_id_sequence'),
    name varchar(50) not null,
    incontinenceDescription text not null
);


CREATE SEQUENCE urinary_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE UrinaryIncontinence (
    id integer primary key default nextval('urinary_id_sequence'),
    incontinence boolean not null,
    date date not null,
    time time not null,
    infirmary integer not null,
    doctor_id integer references Doctor(id) on update restrict on delete restrict not null,
    person_id integer references Person(id) on update restrict on delete restrict not null,
    check (person_id>1)
);


CREATE SEQUENCE gynecologicalturmors_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE GynecologicalTumors (
    id integer primary key default nextval('gynecologicalturmors_id_sequence'),
    name varchar(50) not null,
    tumorDescription text,
    lethal boolean not null
);


CREATE SEQUENCE detectiongynecologicaltumors_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE DetectionOfGynecologicalTumors (
    id integer primary key default nextval('detectiongynecologicaltumors_id_sequence'),
    tumor boolean not null,
    date date not null,
    time time not null,
    infirmary integer not null,
    doctor_id integer references Doctor(id) on update restrict on delete restrict not null,
    person_id integer references Person(id) on update restrict on delete restrict not null,
    gynecologicaltumors_id integer references GynecologicalTumors(id) on update cascade on delete cascade,
    check (person_id>1)
);

CREATE SEQUENCE paptest_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE pap_test (
    id integer primary key default nextval('paptest_id_sequence'),
    outcome varchar(15) not null,
    date date not null,
    time time not null,
    infirmary integer not null,
    doctor_id integer references Doctor(id) on update restrict on delete restrict not null,
    person_id integer references Person(id) on update restrict on delete restrict not null,
    check (person_id>1)
);

CREATE SEQUENCE parametertype_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE ParameterTypes (
    id integer primary key default nextval('parametertype_id_sequence'),
    name varchar(50) not null,
    description text not null,
    unit varchar(20)
);

CREATE SEQUENCE bloodtest_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE BloodTest ( 
    id integer primary key default nextval('bloodtest_id_sequence'), 
    analysis text not null,
    date date not null,
    time time not null,
    infirmary integer not null,
    doctor_id integer references Doctor(id) on update restrict on delete restrict not null,
    person_id integer references Person(id) on update restrict on delete restrict not null,
    check (person_id>1)
);


//connect Paramaters and BloodTest

CREATE TABLE Parameters (
    bloodTest_id integer references BloodTest(id) on update restrict on delete restrict not null,
    type_id integer references ParameterTypes(id) on update restrict on delete restrict not null,
    result varchar(50) not null,
    result_description text,
    CONSTRAINT "primaryKey" primary key (bloodTest_id, type_id)
);

-- default insert

INSERT INTO person VALUES(0, 'DEFAULT-F', 'DEFAULT-F', '1900-02-01','F','12345AaZ', 1,0,0,0);
INSERT INTO person VALUES(1, 'DEFAULT-M', 'DEFAULT-M', '1900-02-01','M','12345AaZ', 1,0,0,0);

--values 
--//TODO INSERT VALUES into the database

--Test that the date of birth is greater than 1900
CREATE function checkdateofbirth()
RETURNS TRIGGER
language plpgsql    
as $$
begin
    if new.dateofbirth <= '01-01-1900' then raise exception 
        'Date of birth error';
    else return new;
    end if;
end
$$;

CREATE TRIGGER checkdateofbirth
BEFORE INSERT OR UPDATE ON person
FOR EACH ROW 
execute procedure checkdateofbirth();

--To see that the mother and father exist
CREATE function checkexistmotherfather()
RETURNS TRIGGER
language plpgsql    
as $$
begin
    if EXISTS(SELECT id FROM person WHERE id = new.person_id_mother) AND EXISTS(SELECT id FROM person WHERE id = new.person_id_father) then 
        return new;
    else raise exception 
        'Error: Parents not exists';
    end if;
end
$$;


CREATE TRIGGER checkexistmotherfather
BEFORE INSERT OR UPDATE ON person
FOR EACH ROW 
execute procedure checkexistmotherfather();

--Check that the parents' gender matches

CREATE function checkgenderparents()
RETURNS TRIGGER
language plpgsql    
as $$
begin
    if (SELECT gender FROM person WHERE id = new.person_id_mother) LIKE 'F' AND (SELECT gender FROM person WHERE id = new.person_id_father) LIKE 'M' then 
        return new;
    else raise exception 
        'Error: Parents gender error';
    end if;
end
$$;


CREATE TRIGGER checkgenderparents
BEFORE INSERT OR UPDATE ON person
FOR EACH ROW 
execute procedure checkgenderparents();

--Check that the test date is correct

CREATE OR REPLACE function checkdateoftest()
RETURNS TRIGGER
language plpgsql    
as $$
declare
    table_date date ;
begin
    execute format('SELECT date  FROM %I WHERE person_id = %L ORDER BY date DESC LIMIT 1', TG_TABLE_NAME, new.person_id) into table_date;
    
    if table_date >= new.date AND table_date IS NOT NULL then
      raise exception 'There is a problem with the date entered';
    else return new ;
    end if;
end;
$$;

CREATE TRIGGER checkdateofbloodtest
BEFORE INSERT OR UPDATE ON bloodtest
FOR EACH ROW 
execute procedure checkdateoftest();

CREATE TRIGGER checkdateofctg
BEFORE INSERT OR UPDATE ON ctg
FOR EACH ROW 
execute procedure checkdateoftest();

CREATE TRIGGER checkdateofbloodtestdetectionofgynecologicaltumors
BEFORE INSERT OR UPDATE ON detectionofgynecologicaltumors
FOR EACH ROW 
execute procedure checkdateoftest();

CREATE TRIGGER checkdateofgynecological_examination
BEFORE INSERT OR UPDATE ON gynecological_examination
FOR EACH ROW 

execute procedure checkdateoftest();

CREATE TRIGGER checkdateofpap_test
BEFORE INSERT OR UPDATE ON pap_test
FOR EACH ROW 

execute procedure checkdateoftest();

CREATE TRIGGER checkdateofultrasound
BEFORE INSERT OR UPDATE ON ultrasound
FOR EACH ROW 

execute procedure checkdateoftest();

CREATE TRIGGER checkdateofurinaryincontinence
BEFORE INSERT OR UPDATE ON urinaryincontinence
FOR EACH ROW 

execute procedure checkdateoftest();


--Verify that the gender of the persons entered for the test is female

CREATE function checkgenderisfemale()
RETURNS TRIGGER
language plpgsql    
as $$
begin
    if (SELECT gender FROM person WHERE id = new.person_id) LIKE 'M' then raise exception 
        'The person entered is not a female';
    else return new;
    end if;
end;
$$;

CREATE TRIGGER checkgenderofbloodtest
BEFORE INSERT OR UPDATE ON bloodtest
FOR EACH ROW 
execute procedure checkgenderisfemale();

CREATE TRIGGER checkgenderofctg
BEFORE INSERT OR UPDATE ON ctg
FOR EACH ROW 
execute procedure checkgenderisfemale();

CREATE TRIGGER checkgenderofbloodtestdetectionofgynecologicaltumors
BEFORE INSERT OR UPDATE ON detectionofgynecologicaltumors
FOR EACH ROW 
execute procedure checkgenderisfemale();

CREATE TRIGGER checkgenderofgynecological_examination
BEFORE INSERT OR UPDATE ON gynecological_examination
FOR EACH ROW 

execute procedure checkgenderisfemale();

CREATE TRIGGER checkgenderofpap_test
BEFORE INSERT OR UPDATE ON pap_test
FOR EACH ROW 

execute procedure checkgenderisfemale();

CREATE TRIGGER checkgenderofultrasound
BEFORE INSERT OR UPDATE ON ultrasound
FOR EACH ROW 

execute procedure checkgenderisfemale();

CREATE TRIGGER checkgenderofurinaryincontinence
BEFORE INSERT OR UPDATE ON urinaryincontinence
FOR EACH ROW 

execute procedure checkgenderisfemale();

CREATE TRIGGER checkgenderofpregnancyhistory
BEFORE INSERT OR UPDATE ON pregnancyhistory
FOR EACH ROW 

execute procedure checkgenderisfemale();


--Check password form

CREATE function checkpassword()
RETURNS TRIGGER
language plpgsql    
as $$
begin
    if (new.password LIKE '%[a-z]%') then
         raise exception 
        'The password must contain at least one UPPER CASE, one lower case, one number and 8 characters';
    elseif(new.password LIKE '%[A-Z]%') then
    raise exception 
        'The password must contain at least one upper case, one LOWER CASE, one number and 8 characters';
    elseif(new.password LIKE '%[0-9]%') then
    raise exception 
        'The password must contain at least one upper case, one lower case, ONE NUMBER and 8 characters';
    elseif ( LENGTH(new.password)< 8) then
    raise exception 
        'The password must contain at least one upper case, one lower case, one number and 8 CHARACTERS';
    else
        return new;
    end if;
end;
$$;

--Password encryption

CREATE TRIGGER checkpassworddoctor
BEFORE INSERT OR UPDATE ON doctor
FOR EACH ROW 

execute procedure checkpassword();

CREATE TRIGGER checkpasswordperson
BEFORE INSERT OR UPDATE ON person
FOR EACH ROW 

execute procedure checkpassword();


CREATE function md5Password()
RETURNS TRIGGER
language plpgsql    
as $$
declare
    password varchar(64);
begin
    if (new.password IS NOT NULL) then
        execute format('SELECT MD5(%L)  FROM person LIMIT 1', new.password) into password;
        new.password = password;
    end if;
    return new;

end;
$$;

CREATE TRIGGER md5passworddoctor
BEFORE INSERT OR UPDATE ON doctor
FOR EACH ROW 

execute procedure md5Password();

CREATE TRIGGER md5passwordperson
BEFORE INSERT OR UPDATE ON person
FOR EACH ROW 

execute procedure md5Password();

--Display the date of the next appointment

CREATE function datefornextmeet()
RETURNS TRIGGER
language plpgsql    
as $$
declare
    datestart date ;
    datediff integer ;
begin
    execute format('SELECT beginningofpregnancy FROM pregnancyhistory WHERE person_id = %L', new.person_id) into datestart;
    datediff = CURRENT_DATE - datestart;
    
    datediff = 210;
    if  datediff<= 210
        then raise notice 'The next appointment in 4 weeks is the % ', (new.date + INTERVAL '4 week')::date;
        return new;
    elseif datediff <= 252
        then  raise notice 'The next appointment in 2 weeks is the %', (new.date + INTERVAL '2 week')::date; 
        return new;
    elseif datediff<= 259
        then  raise notice 'The next appointment in 1 weeks is the %', (new.date + INTERVAL '1 week')::date; 
        return new;
    end if;
end;
$$;


CREATE TRIGGER datefornextmeetofpap_test
BEFORE INSERT OR UPDATE ON pap_test
FOR EACH ROW 
execute procedure datefornextmeet();


CREATE TRIGGER datefornextmeetofbloodtest
BEFORE INSERT OR UPDATE ON bloodtest
FOR EACH ROW 
execute procedure datefornextmeet();

CREATE TRIGGER datefornextmeetofctg
BEFORE INSERT OR UPDATE ON ctg
FOR EACH ROW 
execute procedure datefornextmeet();

CREATE TRIGGER datefornextmeetofbloodtestdetectionofgynecologicaltumors
BEFORE INSERT OR UPDATE ON detectionofgynecologicaltumors
FOR EACH ROW 
execute procedure datefornextmeet();

CREATE TRIGGER datefornextmeetofgynecological_examination
BEFORE INSERT OR UPDATE ON gynecological_examination
FOR EACH ROW 

execute procedure datefornextmeet();

CREATE TRIGGER datefornextmeetofultrasound
BEFORE INSERT OR UPDATE ON ultrasound
FOR EACH ROW 

execute procedure datefornextmeet();

CREATE TRIGGER datefornextmeetofurinaryincontinence
BEFORE INSERT OR UPDATE ON urinaryincontinence
FOR EACH ROW 

execute procedure datefornextmeet();


-- Check date is not lower of the start of pregnancy

CREATE function datechecklowofstartpregnancy()
RETURNS TRIGGER
language plpgsql    
as $$
declare
    datestart date ;
    datediff integer ;
begin
    execute format('SELECT beginningofpregnancy FROM pregnancyhistory WHERE person_id = %L', new.person_id) into datestart;
    datediff = new.date - datestart;
    if datediff < 0 then 
        raise exception 'There is a problem with the date entered is lower of start of pregnancy' ;
    else return new; 
    end if;

end;
$$;

CREATE TRIGGER datechecklowofstartpregnancyofpap_test
BEFORE INSERT OR UPDATE ON pap_test
FOR EACH ROW 
execute procedure datechecklowofstartpregnancy();


CREATE TRIGGER datechecklowofstartpregnancyofbloodtest
BEFORE INSERT OR UPDATE ON bloodtest
FOR EACH ROW 
execute procedure datechecklowofstartpregnancy();

CREATE TRIGGER datechecklowofstartpregnancyofctg
BEFORE INSERT OR UPDATE ON ctg
FOR EACH ROW 
execute procedure datechecklowofstartpregnancy();

CREATE TRIGGER datechecklowofstartpregnancyofbloodtestdetectionofgynecologicaltumors
BEFORE INSERT OR UPDATE ON detectionofgynecologicaltumors
FOR EACH ROW 
execute procedure datechecklowofstartpregnancy();

CREATE TRIGGER datechecklowofstartpregnancyofgynecological_examination
BEFORE INSERT OR UPDATE ON gynecological_examination
FOR EACH ROW 

execute procedure datechecklowofstartpregnancy();

CREATE TRIGGER datechecklowofstartpregnancyofultrasound
BEFORE INSERT OR UPDATE ON ultrasound
FOR EACH ROW 

execute procedure datechecklowofstartpregnancy();

CREATE TRIGGER datechecklowofstartpregnancyofurinaryincontinence
BEFORE INSERT OR UPDATE ON urinaryincontinence
FOR EACH ROW 

execute procedure datechecklowofstartpregnancy();


-- Check date is not futur of the current date

CREATE function datechecknotfutur()
RETURNS TRIGGER
language plpgsql    
as $$
declare
    datestart date ;
    datediff integer ;
begin
    execute format('SELECT beginningofpregnancy FROM pregnancyhistory WHERE person_id = %L', new.person_id) into datestart;
    datediff = CURRENT_DATE - new.date;
    if datediff < 0 then 
        raise exception 'There is a problem with the date entered is futur' ;
    else return new; 
    end if;

end;
$$;

CREATE TRIGGER datechecknotfuturofpap_test
BEFORE INSERT OR UPDATE ON pap_test
FOR EACH ROW 
execute procedure datechecknotfutur();


CREATE TRIGGER datechecknotfuturofbloodtest
BEFORE INSERT OR UPDATE ON bloodtest
FOR EACH ROW 
execute procedure datechecknotfutur();

CREATE TRIGGER datechecknotfuturofctg
BEFORE INSERT OR UPDATE ON ctg
FOR EACH ROW 
execute procedure datechecknotfutur();

CREATE TRIGGER datechecknotfuturofbloodtestdetectionofgynecologicaltumors
BEFORE INSERT OR UPDATE ON detectionofgynecologicaltumors
FOR EACH ROW 
execute procedure datechecknotfutur();

CREATE TRIGGER datechecknotfuturofgynecological_examination
BEFORE INSERT OR UPDATE ON gynecological_examination
FOR EACH ROW 

execute procedure datechecknotfutur();

CREATE TRIGGER datechecknotfuturofultrasound
BEFORE INSERT OR UPDATE ON ultrasound
FOR EACH ROW 

execute procedure datechecknotfutur();

CREATE TRIGGER datechecknotfuturofurinaryincontinence
BEFORE INSERT OR UPDATE ON urinaryincontinence
FOR EACH ROW 

execute procedure datechecknotfutur();


-- Check is the id of mother and father is different of the id of person

CREATE function checkidofparentisnotidenticalofchild()
RETURNS TRIGGER
language plpgsql    
as $$
begin
    if new.id = new.person_id_father OR  new.id = new.person_id_mother then 
        raise exception 'The ID of the parents is identical to that of the child' ;
    else return new; 
    end if;

end;
$$;

CREATE TRIGGER checkidofparentisnotidenticalofchildinperson
BEFORE INSERT OR UPDATE ON person
FOR EACH ROW 
execute procedure checkidofparentisnotidenticalofchild();


-- Remove the number of unborn people in pregnancy after born

CREATE function removechildunborninpregnancy()
RETURNS TRIGGER
language plpgsql    
as $$
declare
    numberofunborn integer;
begin
    if new.pregnancy_id!=0 then
        execute format('SELECT numberofbornchildren FROM person WHERE id = %L', new.person_id_mother) into numberofunborn;
        
        raise notice 'The child has been marked as born';
        numberofunborn = numberofunborn + 1;
        execute format('UPDATE person SET numberofbornchildren= %L WHERE id = %L', numberofunborn, new.person_id_mother);
        return new;
        
    else return new;
    end if;
    
end;
$$;

CREATE TRIGGER removechildunborninpregnancy
BEFORE INSERT OR UPDATE ON person
FOR EACH ROW 
execute procedure removechildunborninpregnancy();



--Display id after add


CREATE function displayid()
RETURNS TRIGGER
language plpgsql    
as $$
declare
    id integer;
begin
    raise notice 'The ID is : %',new.id;
    return new;

end;
$$;

CREATE TRIGGER displayidforperson
BEFORE INSERT ON person
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforIncontinences
BEFORE INSERT ON Incontinences
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforcolordoopler
BEFORE INSERT ON ColorDoppler
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforultrasound
BEFORE INSERT ON Ultrasound
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforctg
BEFORE INSERT ON CTG
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforGynecological_examination
BEFORE INSERT ON Gynecological_examination
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforPregnancyHistory
BEFORE INSERT ON PregnancyHistory
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforUrinaryIncontinence
BEFORE INSERT ON UrinaryIncontinence
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforGynecologicalTumors
BEFORE INSERT ON GynecologicalTumors
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforDetectionOfGynecologicalTumors
BEFORE INSERT ON DetectionOfGynecologicalTumors
FOR EACH ROW 
execute procedure displayid();


CREATE TRIGGER displayidforpap_test
BEFORE INSERT ON pap_test
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforParameterTypes
BEFORE INSERT ON ParameterTypes
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidforBloodTest
BEFORE INSERT ON bloodTest
FOR EACH ROW 
execute procedure displayid();

CREATE TRIGGER displayidfordoctor
BEFORE INSERT ON doctor
FOR EACH ROW 
execute procedure displayid();


--Check the id of mother in pregnacy history

CREATE function checkidmotherinpregnancy()
RETURNS TRIGGER
language plpgsql    
as $$
declare
    idmother integer;
begin
    execute format('SELECT person_id FROM pregnancyhistory WHERE id = %L', new.pregnancy_id) into idmother;
    if idmother != new.person_id_mother then
        raise exception 'Problem with the ID of mother. Is not the same in pregnancy history';
    else return new;
    end if;
    
end;
$$;

CREATE TRIGGER checkidmotherinpregnancy
BEFORE INSERT OR UPDATE ON person
FOR EACH ROW 
execute procedure checkidmotherinpregnancy();


INSERT INTO Hospital (name, address, city, zipcode) 
VALUES 
    ('Mayo Clinic','200 First St. SW','Rochester','MN 55905'),
    ('Cleveland Clinic','9500 Euclid Ave','Cleveland Ohio','44195'),
    ('Massachusetts General Hospital','55 Fruit Street Boston','Massachusetts','MA 02114'),
    ('UCLA Health: Ronald Reagan Medical Center','757 Westwood Plaza','Los Angeles','CA 90095'),
    ('St Thomas Hospital ','Westminster Bridge Rd','London','SE1 7EH'),
    ('University College Hospital','235 Euston Rd','London','NW1 2BU'),
    ('Addenbrooke Hospital','Hills Rd','Cambridge','CB2 0QQ'),
    ('AIIMS Hospital','Ansari Nagar','New Delhi','110029'),
    ('TATA Hospital','2R3V+V5C, Parel East,','Mumbai','400012'),
    ('Apollo Hospital','21, Greams Lane','Off Greams Road Chennai','600006');

INSERT INTO doctor (name, surname, hospital_id, password) 
VALUES
    ('Rajesh', 'Patel','8','admin123A'),
    ('Priya', 'Sharma','9','admin123A'),
    ('Sanjay', 'Gupta','10','admin123A'),
    ('Megha', 'Shah','8','admin123A'),
    ('Rohan', 'Patel','9','admin123A'),
    ('Kavya', 'Patel','9','admin123A'),
    ('Vikram', 'Singh','10','admin123A'),
    ('Sushmita', 'Gupta','8','admin123A'),
    ('Tanvi', 'Shah','8','admin123A'),
    ('Aryan', 'Patel','9','admin123A'),
    ('Mukesh', 'Kumar','10','admin123A'),
    ('Nitya', 'Patel','9','admin123A'),
    ('Manish', 'Gupta','8','admin123A'),
    ('Michael', 'Smith','2','admin123A'),
    ('Jennifer', 'Johnson','1','admin123A'),
    ('David', 'Williams','2','admin123A'),
    ('Susan', 'Brown','3','admin123A'),
    ('Robert', 'Jones','4','admin123A'),
    ('Mark', 'Miller','3','admin123A'),
    ('James', 'Davis','3','admin123A'),
    ('Christopher', 'Anderson','1','admin123A'),
    ('Brian', 'Wilson','1','admin123A'),
    ('Kevin', 'Moore','1','admin123A'),
    ('Ronald', 'Taylor','5','admin123A'),
    ('Melissa', 'Thomas','7','admin123A'),
    ('Laura', 'Hernandez','5','admin123A'),
    ('Michael', 'Gonzalez','6','admin123A'),
    ('William', 'Adams','6','admin123A'),
    ('James', 'May','7','admin123A');

INSERT INTO Person (id,name, surname, dateOfBirth, gender, password, person_id_father, person_id_mother, numberofbornchildren, pregnancy_id) 
VALUES
    (2, 'Emily', 'Taylor', '1995-01-01', 'F', 'admin123A',1 ,0 , 2, 0),
    (3, 'Sarah', 'White', '1996-02-01', 'F', 'admin123A',1 ,0 , 2, 0),
    (4, 'Elizabeth', 'King', '1997-03-01', 'F', 'admin123A',1 ,0 , 2, 0),
    (5, 'Kavya', 'Patel', '1998-04-01', 'F', 'admin123A',1 ,0 , 2, 0),
    (6, 'Sushmita', 'Gupta', '1999-05-01', 'F', 'admin123A',1 , 0, 2, 0),
    (7, 'Tanvi', 'Shah', '2000-06-01', 'F', 'admin123A', 1, 0, 2, 0),
    (8, 'Nitya', 'Patel', '2001-07-01', 'F', 'admin123A', 1, 0, 1, 0),
    (9, 'Melissa', 'Thomas', '2002-08-01', 'F', 'admin123A', 1, 0, 1, 0),
    (10, 'Laura', 'Hernandez', '2003-09-01', 'F', 'admin123A', 1, 0, 1, 0),
    (11, 'Jennifer', 'Johnson', '2004-10-01', 'F', 'admin123A',1, 0, 1, 0),
    (12, 'Michael', 'Smith', '1995-01-01', 'M', 'admin123A', 1, 0, 0, 0),
    (13, 'David', 'Johnson', '1996-02-01', 'M', 'admin123A', 1,0, 0, 0),
    (14, 'Robert', 'Williams', '1997-03-01', 'M', 'admin123A', 1, 0, 0, 0),
    (15, 'Mark', 'Jones', '1998-04-01', 'M', 'admin123A', 1, 0, 0, 0),
    (16, 'James', 'Brown', '1999-05-01', 'M', 'admin123A', 1,0, 0, 0),
    (17, 'Christopher', 'Moore', '2000-06-01', 'M', 'admin123A', 1, 0, 0, 0),
    (18, 'Brian', 'Taylor', '2001-07-01', 'M', 'admin123A', 1, 0, 0, 0),
    (19, 'Ronald', 'Anderson', '2002-08-01', 'M', 'admin123A', 1, 0, 0, 0),
    (20, 'Kevin', 'Thomas', '2003-09-01', 'M', 'admin123A', 1, 0, 0, 0),
    (21, 'George', 'Hernandez', '2004-10-01', 'M', 'admin123A', 1, 0, 0, 0);


INSERT INTO PregnancyHistory (beginningOfPregnancy, outcome, numberOfBornChildren, numberOfUnbornChildren, person_id, doctor_id)
VALUES
    ('2016-01-01', 'Successful', 0, 1, 2, 1),
    ('2016-02-01', 'Successful', 0, 1, 3, 2),
    ('2016-03-01', 'Successful', 0, 1, 4, 3),
    ('2016-04-01', 'Successful', 0, 1, 5, 4),
    ('2016-05-01', 'Successful', 0, 1, 6, 5),
    ('2016-06-01', 'Successful', 0, 1, 8, 6),
    ('2016-07-01', 'Successful', 0, 1, 9, 7),
    ('2016-08-01', 'Successful', 0, 1, 10, 8),
    ('2016-09-01', 'Successful', 0, 1, 11, 9),
    ('2016-10-01', 'Successful', 0, 1, 11, 10),
    ('2016-01-01', 'Successful', 1, 1, 2, 11),
    ('2016-02-01', 'Successful', 1, 1, 3, 12),
    ('2016-03-01', 'Successful', 1, 1, 4, 1),
    ('2016-04-01', 'Successful', 1, 1, 5, 2),
    ('2016-05-01', 'Successful', 1, 1, 6, 3),
    ('2016-06-01', 'Successful', 1, 1, 7, 4);

INSERT INTO Person (id,name, surname, dateOfBirth, gender, password, person_id_father, person_id_mother, numberofbornchildren, pregnancy_id) 
VALUES
    (22, 'Emily', 'Taylor', '2016-01-01', 'F', 'admin123A',12 ,2 , 0, 1),
    (23, 'Sarah', 'White', '2016-02-01', 'F', 'admin123A',13 ,3 , 0, 2),
    (24, 'Elizabeth', 'King', '2016-03-01', 'F', 'admin123A',14 ,4 , 0, 3),
    (25, 'Kavya', 'Patel', '2016-04-01', 'F', 'admin123A',15 ,5 , 0, 4),
    (26, 'Sushmita', 'Gupta', '2016-05-01', 'F', 'admin123A',16 , 6, 0, 5),
    (27, 'Tanvi', 'Shah', '2016-06-01', 'F', 'admin123A', 17, 7, 0, 6),
    (28, 'Nitya', 'Patel', '2016-07-01', 'F', 'admin123A', 18, 8, 0, 7),
    (29, 'Melissa', 'Thomas', '2016-08-01', 'F', 'admin123A', 19, 9, 0, 8),
    (30, 'Laura', 'Hernandez', '2016-09-01', 'F', 'admin123A', 20, 10, 0, 9),
    (31, 'Jennifer', 'Johnson', '2016-10-01', 'F', 'admin123A',21, 11, 0, 10),
    (32, 'Michael', 'Smith', '2016-01-01', 'M', 'admin123A', 21, 11, 0, 11),
    (33, 'David', 'Johnson', '2016-02-01', 'M', 'admin123A', 12,2,22, 12),
    (34, 'Robert', 'Williams', '2016-03-01', 'M', 'admin123A', 13, 3, 0, 13),
    (35, 'Mark', 'Jones', '2016-04-01', 'M', 'admin123A', 14, 4, 0, 14),
    (36, 'James', 'Brown', '2016-05-01', 'M', 'admin123A', 15,5,0, 15);

INSERT INTO ParameterTypes (name, description, unit)
VALUES ('Complete Blood Count (CBC)', 'Measures the number and types of cells in your blood, including red blood cells, white blood cells, and platelets.', 'cells/microliter'),
       ('Blood Chemistry', 'Measures levels of electrolytes, enzymes, glucose, and other substances in your blood.', 'mg/dL'),
       ('Blood Lipids', 'Measures levels of cholesterol and triglycerides in your blood.', 'mg/dL'),
       ('Liver Function Test', 'Measures levels of enzymes and proteins in your blood that are related to liver function.', 'U/L'),
       ('Kidney Function Test', 'Measures levels of creatinine, urea, and other substances in your blood that are related to kidney function.', 'mg/dL'),
       ('Thyroid Function Test', 'Measures levels of thyroid hormones and thyroid-stimulating hormone in your blood.', 'mIU/L'),
       ('Coagulation Test', 'Measures your bloods ability to clot.', 'seconds'),
       ('Hormone Test', 'Measures levels of hormones in your blood, such as testosterone, estrogen, and thyroid hormones.', 'ng/dL'),
       ('Tumor Markers Test', 'Measures levels of certain substances in your blood that can be indicators of certain types of cancer.', 'ng/mL'),
       ('Vitamin and Mineral Test', 'Measures levels of vitamins and minerals in your blood, such as vitamin D, vitamin B12 and Iron.', 'ng/mL');


INSERT INTO gynecologicaltumors (name, description, lethal)
VALUES ('Endometrial Cancer', 'Cancer that starts in the lining of the uterus (endometrium).', false),
       ('Cervical Cancer', 'Cancer that starts in the cervix (the lower part of the uterus that opens into the vagina).', true),
       ('Ovarian Cancer', 'Cancer that starts in the ovaries (female reproductive organs that make eggs).', true),
       ('Vaginal Cancer', 'Cancer that starts in the vagina (birth canal).', false),
       ('Vulvar Cancer', 'Cancer that starts in the vulva (the external female genital area).', false),
       ('Gestational Trophoblastic Disease', 'A group of rare tumors that form in a woman uterus during pregnancy.', false),
       ('Uterine Sarcoma', 'A type of cancer that starts in the muscles of the uterus or the tissue around the uterus.', true),
       ('Fallopian Tube Cancer','A type of cancer that forms on a fallopian tube of a woman', false);


INSERT INTO Incontinences (name, Description)
VALUES ('Stress incontinence', 'Leakage of urine during physical activity, coughing, sneezing, or laughing.'),
       ('Urge incontinence', 'A sudden and strong need to urinate followed by an involuntary loss of urine.'),
       ('Overflow incontinence', 'Leakage of urine due to a bladder that does not empty completely.'),
       ('Functional incontinence', 'Leakage of urine due to a physical or cognitive impairment that makes it difficult to reach the toilet in time.'),
       ('Mixed incontinence', 'A combination of stress and urge incontinence.'),
       ('Transient incontinence', 'Temporary leakage of urine due to a temporary medical condition or medication side effect.'),
       ('Neurogenic incontinence', 'Leakage of urine caused by damage or disease of the nervous system.'),
       ('Post-operative incontinence', 'Leakage of urine after surgery, especially after prostate or pelvic surgery.'),
       ('Enuresis', 'Involuntary urination, especially in children.'),
       ('Nocturnal enuresis', 'Involuntary urination during sleep, especially in children.');