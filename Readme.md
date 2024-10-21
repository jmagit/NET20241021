# Testing .Net y QA

## Documentación

- [Pruebas en .NET](https://learn.microsoft.com/es-es/dotnet/core/testing/)
- [Visual Studio Testing](https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022)

## Instalación

- [Visual Studio](https://visualstudio.microsoft.com/es/downloads/)
- [Visual Studio Code](https://code.visualstudio.com/download#)

### Utilidades

- [Git](https://git-scm.com/)
- [Node.js LTS](https://nodejs.org)

### Pruebas E2E

- [Selenium IDE](https://chromewebstore.google.com/detail/selenium-ide/mooikfkahbdckldjjndioackbalphokd?hl=es&utm_source=ext_sidebar)
- [Postman](https://www.postman.com/downloads/)
- [SoapUI](https://www.soapui.org/downloads/soapui/)

### Pruebas de rendimiento

- [JMeter](https://jmeter.apache.org/download_jmeter.cgi)

### Instalación Docker

- [WSL 2 feature on Windows](https://learn.microsoft.com/es-es/windows/wsl/install)
- [Docker Desktop](https://www.docker.com/get-started/)

### Contenedores

#### SonarQube

    docker run -d --name sonarqube --publish 9000:9000 sonarqube:latest

#### SQL Server

    docker run -d --name mssql2022 -p 1433:1433 -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=P@$$w0rd" -v "%cd%":/var/backups mcr.microsoft.com/mssql/server:2022-latest

## Kata

- [GildedRose](https://github.com/emilybache/GildedRose-Refactoring-Kata/blob/main/GildedRoseRequirements_es.md)

## Servicios Web SOAP

- http://www.dneonline.com/calculator.asmx
- http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso?WSDL
- https://ovc.catastro.meh.es/ovcservweb/ovcswlocalizacionrc/ovccallejero.asmx?WSDL

## Servicios Web REST

- https://petstore.swagger.io/
- https://httpbin.org/
- https://jsonplaceholder.typicode.com/
