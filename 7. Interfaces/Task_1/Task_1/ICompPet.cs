internal interface ICompPet
{
    bool IsCompanion { get; }
    string TypeName();
    string Voice();
}