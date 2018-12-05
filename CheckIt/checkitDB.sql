DROP TABLE client;
DROP TABLE user_actions;
DROP TABLE qa;
DROP TABLE users;


CREATE TABLE user (
        userID INT(20) NOT NULL,
        email VARCHAR(50) NOT NULL,
        clientID INT(50) NOT NULL,
        firstName VARCHAR(20) NOT NULL,
        lastName VARCHAR(20) NOT NULL,
        dob VARCHAR(20) NOT NULL,
        parentID INT (50) NOT NULL,
        height INT(5) NOT NULL,
        accountType VARCHAR(20) NOT NULL,
        status VARCHAR (10) NOT NULL,
        qA VARCHAR (20) NOT NULL,
        password VARCHAR(20) NOT NULL,
        CONSTRAINT user_pk PRIMARY KEY (userID)
        );

CREATE TABLE qa (
  email VARCHAR(20),
  question VARCHAR(20),
  answer VARCHAR(20),
  CONSTRAINT qa_pk PRIMARY KEY (email),
  CONSTRAINT qa_pk FOREIGN KEY (email),
    REFERENCES user (email)
);

CREATE TABLE user_actions (
  userID INT(20) NOT NULL,
  action VARCHAR(50) NOT NULL,
  CONSTRAINT user_actions_pk PRIMARY KEY (userID),
  CONSTRAINT user_actions_fk FOREIGN KEY (userID),
    REFERENCES user (userID)
);

CREATE TABLE client (
  clientID INT(20),
  name VARCHAR(20),
  CONSTRAINT client_pk PRIMARY KEY (clientID),
);

INSERT INTO user
  VALUES (10, 'one@gmail.com', 100, 'Michael', 'Jones','12/04/2001',0,1,'System Admin','Active','qa_placeholder','apple'),
  VALUES (20, 'two@gmail.com', 200, 'Rylee', 'Raymond','11/02/1922',10,2,'Admin','Active','qa_placeholder','banana'),
  VALUES (30, 'three@gmail.com',300, 'Pierre', 'Davenport','10/07/2004',20,3,'User','Active','qa_placeholder','orange'),
  VALUES (40, 'four@gmail.com', 400, 'Courtney', 'Pham','09/13/1994',20,3,'User','Active','qa_placeholder','lemon');

INSERT INTO qa
  VALUES ('one@gmail.com', 'question1','answer1'),
  VALUES ('gmail@gmail.com', 'question2','answer2'),
  VALUES ('three@gmail.com', 'question3','answer3')
  VALUES ('three@four.com', 'question4','answer3');

INSERT INTO user_actions
  VALUES (10,'action1'),
  VALUES (20,'action2'),
  VALUES (30,'action3'),
  VALUES (40,'action4');

INSERT INTO client
  VALUES (100,'name1'),
  VALUES (200,'name2'),
  VALUES (300,'name3'),
  VALUES (400,'name4');