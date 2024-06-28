﻿using Pulumi;
using AzureNative = Pulumi.AzureNative;
using Pulumi.AzureNative.Resources;
using Pulumi.AzureNative.Storage;
using Pulumi.AzureNative.Storage.Inputs;
using System.Collections.Generic;
using System.Linq;

return await Pulumi.Deployment.RunAsync(() =>
{
    // Create an Azure Resource Group
    // https://www.pulumi.com/registry/packages/azure-native/api-docs/resources/resourcegroup/
    var resourceGroup = new ResourceGroup("Main", new()
    {
        ResourceGroupName = "patrik-majer-playground-rg",
    });

    var userAssignedIdentity = new AzureNative.ManagedIdentity.UserAssignedIdentity("userAssignedIdentity", new()
    {
        ResourceGroupName = resourceGroup.Name,
        ResourceName = "myIdentity-1",
        
    });
    
    // Create an Azure resource (Storage Account)
    // var storageAccount = new StorageAccount("sa", new StorageAccountArgs
    // {
    //     ResourceGroupName = resourceGroup.Name,
    //     Sku = new SkuArgs
    //     {
    //         Name = SkuName.Standard_LRS
    //     },
    //     Kind = Kind.StorageV2
    // });

    // var storageAccountKeys = ListStorageAccountKeys.Invoke(new ListStorageAccountKeysInvokeArgs
    // {
    //     ResourceGroupName = resourceGroup.Name,
    //     AccountName = storageAccount.Name
    // });

    // var primaryStorageKey = storageAccountKeys.Apply(accountKeys =>
    // {
    //     var firstKey = accountKeys.Keys[0].Value;
    //     return Output.CreateSecret(firstKey);
    // });

    // // Export the primary key of the Storage Account
    // return new Dictionary<string, object?>
    // {
    //     ["primaryStorageKey"] = primaryStorageKey
    // };
});
