# Attempt to replicate GET request getting stuck when there is reference to netstandard 2.0

Reproduced on my machine with:

* dotnet-sdk-2.0.0-preview2-006497-win-x64
* VS2017 Preview 7.0 (version 15.3)

Instructions:
1) Compile the solution
2) Run WebServiceTest executable - this creates webservice with one GET endpoint at http://localhost:9000/foo
3) Run TestWebRequestGettingStuck
4) If EmptyNetstandardLib reference is removed from TestWebRequestGettingStuck - the loop with GET requests runs as expected
