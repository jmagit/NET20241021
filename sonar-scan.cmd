@REM dotnet tool install --global dotnet-coverage
dotnet sonarscanner begin /k:"dotnet" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="sqp_925fd4b23dd31be28576374ca3ef7c9ad5730e06" /d:sonar.cs.vscoveragexml.reportsPaths=coverage.xml
dotnet build --no-incremental
dotnet-coverage collect "dotnet test" -f xml -o "coverage.xml"
dotnet sonarscanner end /d:sonar.login="sqp_925fd4b23dd31be28576374ca3ef7c9ad5730e06"