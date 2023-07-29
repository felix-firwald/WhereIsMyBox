using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media.Media3D;
using WhereIsMyBox.Forms;

namespace WhereIsMyBox.Classes
{
    public enum PermissionGroup
    {
        Admin,  // администрирование программой и базой данных, включая выдачу ролей
        Moderator,  // модератор может создавать короба и партии, принудительно переназначать их или удалять
        Operator,   // обычный сотрудник
        Special // обычный сотрудник, но с предоставленным правом определенного действия
    }
    public enum PermissionMode
    {
        Monopoly,   // монопольный режим - только эта группа имеет право
        Rising,     // восходящий режим - эта группа и те, что ВЫШЕ, имеют право
        Cascade,    // каскадный режим - эта группа и те, что НИЖЕ, имеют право
    }
    static class Permission
    {
        private static readonly Dictionary<PermissionGroup, string> visibleName = new Dictionary<PermissionGroup, string>()
        {
            { PermissionGroup.Admin, "Администратор"},
            { PermissionGroup.Moderator, "Модератор"},
            { PermissionGroup.Special, "Оператор со специальными правами"},
            { PermissionGroup.Operator, "Оператор"},
            
        };
        private static readonly Dictionary<PermissionGroup, int> levelAccess = new Dictionary<PermissionGroup, int>()
        {
            { PermissionGroup.Admin, 4},
            { PermissionGroup.Moderator, 3},
            { PermissionGroup.Special, 2},
            { PermissionGroup.Operator, 1},
            
        };
        public static PermissionGroup CurrentUserPermission;

        public static void SetPermissionGroup(PermissionGroup group)
        {
            CurrentUserPermission = group;
        }
        public static string GetVisibleName(PermissionGroup group)
        {
            return visibleName[group];
        }
        public static PermissionGroup GetGroupByVisibleName(string name)
        {
            foreach (KeyValuePair<PermissionGroup, string> group in visibleName)
            {
                if (group.Value == name)
                {
                    return group.Key;
                }
            }
            throw (new Exception($"Unexpected type of permission: \"{name}\" not found in permission groups."));
        }
        private static bool InMonopolyAccess(PermissionGroup required)
        {
            return required == CurrentUserPermission;  // true, если пользователь член этой группы прав
        }
        private static bool InCascadeAccess(PermissionGroup required)
        {
            return levelAccess[CurrentUserPermission] <= levelAccess[required];    // true, если пользователь член этой группы прав или ниже
        }
        private static bool InRisingAccess(PermissionGroup required)
        {
            return levelAccess[CurrentUserPermission] >= levelAccess[required];    // true, если пользователь член этой группы прав или ниже
        }

        public static bool IsUserHavePermission(
            PermissionGroup requiredGroup,
            PermissionMode mode=PermissionMode.Rising
        )
        {
            switch(mode)
            {
                case PermissionMode.Rising: return InRisingAccess(requiredGroup);
                case PermissionMode.Monopoly: return InMonopolyAccess(requiredGroup);
                case PermissionMode.Cascade: return InCascadeAccess(requiredGroup);
                default: throw(new Exception($"Unknown type of permission mode: {mode} got."));
            }
        }

        public static void RaisePermissionError(PermissionGroup requiredGroup, PermissionMode mode=PermissionMode.Monopoly)
        {
            string groupName = GetVisibleName(requiredGroup);
            string addToDescription = "";
            switch(mode)
            {
                case PermissionMode.Rising:
                    addToDescription = " и группы пользователей выше него";
                    break;
                case PermissionMode.Cascade:
                    addToDescription = " и группы пользователей ниже него";
                    break;
            }
            string description = $"Это действие может совершать только {groupName}{addToDescription}. " +
                $"Если вас добавили в группу \"{groupName}\" недавно — попробуйте перезапустить программу";
            MessageBox.Show(description, "Ошибка прав доступа!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Rejected form = new Rejected("Ошибка прав доступа!", description);
            //form.ShowDialog();
        }
    }
}
