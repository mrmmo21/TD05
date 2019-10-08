namespace TD05
{
    public interface IPerson
    {
        string Address { get; set; }
        string EMail { get; set; }
        string FirstName { get; set; }
        Gender Gender { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }

        object Clone();
        void Copy(Person p);
    }
}