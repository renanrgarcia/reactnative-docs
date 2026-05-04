# reactnative-docs

## Delivery App API

Run the .NET 10 mock API:

```bash
dotnet run --project delivery-app-api/src/DeliveryApp.Api
```

Backend solution:

```text
delivery-app-api/DeliveryApp.slnx
```

Base URL:

```text
http://localhost:5000
```

Routes:

```text
POST /products/paginated
GET /products/{id}
```

Example pagination body:

```json
{
  "page": 3,
  "perPage": 5
}
```

## Delivery App Mobile
Run the React Native app:

```bash
npx expo start --clear
``` 