Create database PROG6212_POE_PART_TWO ;
use PROG6212_POE_PART_TWO;

create table tblUsers(
	Username varchar(255) NOT NULL PRIMARY KEY,
	Password varchar(255) NOT NULL 
	);

create table tblModules(
	ModulesID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ModuleCode varchar(255) NOT NULL,
	ModuleName varchar(255) NOT NULL,
	ModuleNumberOfCredits int NOT NULL,
	ModuleClassHoursPerWeek int NOT NULL,
	NumberOfWeeks int NOT NULL,
	StartDate varchar(255) NOT NULL,
	SelfStudyHours int NOT NULL ,
	Username varchar(255) NOT NULL
);

create table tblRemainingStudyHours(
    RemainingModulesHoursID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ModuleName varchar(255) NOT NULL ,
    SelfStudyHours int NOT NULL,
	NumberOfHours int not null,
	DayOfStudy varchar(255) not null,
    RemainingStudyHours int not null,
	Username varchar(255) not null
);