using SOLID_Sample.SingleResponsibility.Entities;
using SOLID_Sample.SingleResponsibility.V2;

//----------------SRP----------------\\

PersonV1 personV1 = new PersonV1
{
    FirstName = "MohammadSoheil",
    LastName = "Mohammadi"
};

personV1.AddToRepository(personV1);

PersonV2 PersonV2 = new PersonV2
{
    FirstName = "Soheil",
    LastName = "Mohammadi",
    Email = "aaa@aaa.com"
};

PersonServieceV2 personServieceV2 = new PersonServieceV2();
personServieceV2.AddToRepository(PersonV2);

Console.ReadKey();