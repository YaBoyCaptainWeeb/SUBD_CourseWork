using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public enum CooperationType
    {
        [PgName("Штатный")]
        Штатный,
        [PgName("Совмещает")]
        Совмещает,
        [PgName("Неизвестно")]
        Неизвестно
    }
    public enum DegreeType
    {
        [PgName("Доктор")]
        Доктор,
        [PgName("Кандидат")]
        Кандидат
    }
    public enum DisciplineType
    {
        [PgName("Технических наук")]
        Технических,
        [PgName("Экономических наук")]
        Экономических,
        [PgName("Математических наук")]
        Математических,
        [PgName("Информационных наук")]
        Информационных,
        [PgName("Философских наук")]
        Философских
    }
    public enum AcademicRankType
    {
        [PgName("Доцент")]
        Доцент,
        [PgName("Профессор")]
        Профессор
    }

    public enum JobTitlesType
    {
        [PgName("Ассистент")]
        Ассистент,
        [PgName("Преподаватель")]
        Преподаватель,
        [PgName("Старший преподаватель")]
        СтПрепр,
        [PgName("Доцент")]
        Доцент,
        [PgName("Профессор")]
        Профессор
    }
}
