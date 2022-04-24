
# Product Feed

Update inventory of SaaS products from several sources. Developed using .NET 5.0



## Installation

Download .NET 5.0 SDK and
clone the project and navigate to ProductFeed.ConsoleApp

```bash
  cd ProductFeed.ConsoleApp
  dotnet build
  dotnet run capterra feed-products/capterra.yaml
```
    
## Appendix

To run test case run command dotnet test

I have used simple factory design pattern for fetching products feed.

If I had more time and the project would be greater, I would have created git branches to develop, branches for features, etc.

I would also improve the implementation of data access layer

