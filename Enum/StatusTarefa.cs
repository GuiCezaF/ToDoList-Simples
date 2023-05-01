using System.ComponentModel;

namespace ToDoList.Enum
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFaser = 1,

        [Description("Em Andamento")]
        EmAndamento = 2,

        [Description("Concluido")]
        Concluido = 3
    }
}