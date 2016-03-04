## Database - For The Win! 

* WebAPI 2.2 project with MS SQL and Oracle support for CRUD operations over HTTP GET and POST.

* TXT file support for common SELECT queries.  Save a TXT file to the INETMGR folder (\dbftw\Sql, \dbftw\Oracle) and easily call with (http://.../dbftw/api/Sql/txt-file-name) 

* Returns XML over HTTP by default for Excel Data Connection support (get XML from URL).  JSON available if HTTP header "accept:application/json" is sent with request.


## Get Started
* Download ZIP and extract
* Open SLN with Visual Studio 2013 or higher
* Open "Package Manager Console" and run "Update-Package" to download assemblies
* F5 to build and run
* Open http://whateversite/api/dbftw/Sql to execute GET and see XML reply
* Open http://whateversite/api/dbftw/Oracle to execute GET and see XML reply


## Notes
* Windows Authentication is enabled
* With Fiddler F9 Composer be sure to check "Options tab > [X] Automatically Authenticate"
* May need to enable Automatic Login for IE, FireFox. Read [http://www.scip.be/index.php?Page=ArticlesNET38]( http://www.scip.be/index.php?Page=ArticlesNET38) for how.


## Contact
Please drop a line to [@spjeff](https://twitter.com/spjeff) or [spjeff@spjeff.com](mailto:spjeff@spjeff.com)
Thanks!  =)

![image](http://img.shields.io/badge/first--timers--only-friendly-blue.svg?style=flat-square)