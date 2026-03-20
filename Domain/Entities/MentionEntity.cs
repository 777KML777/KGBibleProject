namespace Domain.Entities;

public class MentionEntity : Tracker
{
    #region "Optional Properties" 
    #endregion
    #region "Primitive Properties" 
    public string Book { get; set; }
    public string Chapter { get; set; }
    public int OpeningVersus { get; set; }
    public int ClosingVersus { get; set; }
    #endregion
    #region "Nullabes Properties" 
    #endregion
    #region "Enums Properties" 
    #endregion
    #region "Objects Properties" 
    #endregion
    #region "Collections Properties" 
    #endregion
    #region "Relationals Properties" 
    public int? IdDoubt { get; set; }
    public int? IdActivityLog { get; set; }
    #endregion

    #region "TODO: ANOTAÇÕES - Entidade - MentionEntity"
    /*
     public string Bible { get; set; }
     // - Futuramente pegar o nome da bíblia, tipo e versões.
    */
    #endregion 
}