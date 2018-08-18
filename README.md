# Kon School?

| Linux | macOS | Windows |
| -- | -- | -------- |
| [![Build Status](https://travis-ci-job-status.herokuapp.com/badge/maacpiash/KonSchool/master/linux)](https://travis-ci.org/maacpiash/KonSchool) | [![Build Status](https://travis-ci-job-status.herokuapp.com/badge/maacpiash/KonSchool/master/osx)](https://travis-ci.org/maacpiash/KonSchool) | [![Build status](https://ci.appveyor.com/api/projects/status/bsmib72le6n8pc1u?svg=true)](https://ci.appveyor.com/project/maacpiash/konschool) |


*Kon School?* (Bengali: *কোন স্কুল?*, meaning *"Which school?"*) is a system that recommends a secondary school based on user's preferences and school data. The user gives student data (age, sex, class (grade), location, guardian's profession) as input. The user also compares every pair of criteria and gives each pair a relative linguistic value. Then the system
- uses these linguitic values to run Fuzzy Analytic Hierarchy Process (Fuzzy AHP) to evaluate weights of each criterion
- takes data from a dataset on secondary schools of Bangladesh and calculates comparative values for each criterion
- gives each school a score, which is a sum of weighted criteria-values.
<br/>


The dataset used for this system was compiled from several datasets originally collected from [Bangladesh Open Data](http://data.gov.bd/dataset). The SQLite database can be found [here](https://drive.google.com/open?id=1_MZnVRHl0ZLHEMab7lBhpUvuS3yaLoPZ).

### Structure

The .NET Core solution is divided into three projects:
- [KonSchool.API](https://github.com/maacpiash/KonSchool/tree/master/KonSchool.API), a RESTful web API that outputs score values for each alternative schools, based on criteria preferences and alternative selection by the user.
- [KonSchool.App](https://github.com/maacpiash/KonSchool/tree/master/KonSchool.App), a "desktop" application developed with [Electron.NET](https://github.com/ElectronNET/Electron.NET), which can also be used as a general webpage.
- [KonSchool.Models](https://github.com/maacpiash/KonSchool/tree/master/KonSchool.Models), the model classes and actual logic of Fuzzy AHP procedure, along with some helper classes.

Additionally, there is an [xUnit test project](https://github.com/maacpiash/KonSchool/tree/master/KonSchool.Test) for general testing purposes.<br/>
Each of these projects will have their own readme files, very soon 🤞🏽

### Acknowledgement
I am very grateful to [Dr. Mohammad Rashedur Rahman](http://ece.northsouth.edu/people/rashedur-rahman/) sir, our honorable instructor of the Fuzzy Logic course (CSE470) at North South University, who mentored my group on this project and made sure our research work got published in [The 11th edition of International Conference 
on Multimedia & Network Information Systems](https://missi.pwr.edu.pl/2018/).<p>I would also like to thank my groupmates — N.S.M. Rezaur Rahman, for the development of the mathematical model; and [Abdullah-Al Nahian Siraj](https://github.com/Nahian-Siraj), for his cooperation.</p>