CREATE TABLE vueUsers (
  id              INT           NOT NULL    IDENTITY    PRIMARY KEY,
  firstname      VARCHAR(100)  NOT NULL,
  lastname       VARCHAR(100),
  email           VARCHAR(100)  NOT NULL,
);



Insert into vueUsers values ('john', 'doe', 'john.doe@gmail.com')