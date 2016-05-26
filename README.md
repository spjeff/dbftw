## Database - For The Win! 

* WebAPI 2.2 project with MS SQL and Oracle support for CRUD operations over HTTP GET and POST.

* TXT file support for common SELECT queries.  Save a TXT file to the INETMGR folder (\dbftw\Sql, \dbftw\Oracle) and easily call with (http://.../dbftw/api/Sql/txt-file-name) 

* Returns XML over HTTP by default for Excel Data Connection support (get XML from URL).  JSON available if HTTP header "accept:application/json" is sent with request.


## Get Started
* ZIP file at <https://github.com/spjeff/dbftw/blob/master/dbftw/deploy/dbftw.zip>
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

[![Bitdeli Badge](https://d2weczhvl823v0.cloudfront.net/spjeff/dbftw/trend.png)](https://bitdeli.com/free "Bitdeli Badge")

## License

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
