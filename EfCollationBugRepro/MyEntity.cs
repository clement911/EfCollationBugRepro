using System.ComponentModel.DataAnnotations.Schema;

public class MyEntity
{
    public string KeyCol1 { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int KeyCol2 { get; set; }
}


