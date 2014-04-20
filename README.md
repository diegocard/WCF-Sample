WCF-Sample
==========

Example of Windows Communication Foundation

- Contains 2 projects: Service and Client

## Service

Implements a calcultor with 4 operations: 

- Add
- Subtract
- Multiply
- Divide

These operations are exposed at http://localhost:8000/ServiceModelSamples/Service.

## Client

The client calls the service, executing the following operations:
```CSharp
double value1 = 100.00D;
double value2 = 15.99D;
double result = client.Add(value1, value2);
Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

value1 = 145.00D;
value2 = 76.54D;
result = client.Subtract(value1, value2);
Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

value1 = 9.00D;
value2 = 81.25D;
result = client.Multiply(value1, value2);
Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

value1 = 22.00D;
value2 = 7.00D;
result = client.Divide(value1, value2);
Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);
```

The client can be configure through it's App.config file. Here you can change endpoint data, such as it's address.
