namespace Server.Items
{
  public class JeweledFiligree : Item
  {
    [Constructible]
    public JeweledFiligree() : base(0x2F5E) => Weight = 1.0;

    public JeweledFiligree(Serial serial) : base(serial)
    {
    }

    public override int LabelNumber => 1072894; // jeweled filigree

    public override void Serialize(IGenericWriter writer)
    {
      base.Serialize(writer);

      writer.Write(0); // version
    }

    public override void Deserialize(IGenericReader reader)
    {
      base.Deserialize(reader);

      int version = reader.ReadInt();
    }
  }
}