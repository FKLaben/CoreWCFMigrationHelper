using CoreWCFService;

// Use the 'client' variable to call operations on the service.
ServiceClient client = new ServiceClient();

string resultFromRemote = client.GetData(3);

string anotherResultFromRemote = await client.GetDataAsync(4);

CompositeType compositeType = new CompositeType() { StringValue = "Don Quichotte", BoolValue = true };
compositeType = client.GetDataUsingDataContract(compositeType);

CompositeType anotherCompositeTypeInstance = new CompositeType() { StringValue = "Pinocchio", BoolValue = true };
anotherCompositeTypeInstance = await client.GetDataUsingDataContractAsync(anotherCompositeTypeInstance);


// Always close the client.
client.Close();
Console.ReadKey();
