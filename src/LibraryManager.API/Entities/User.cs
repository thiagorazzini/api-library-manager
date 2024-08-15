using LibraryManager.API.Enums;

namespace LibraryManager.API.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public UserStatusEnum Status { get; private set; }
        public StatusUserBlock StatusBlock { get; private set; }
        public DateTime BlockUntil { get; set; }

        public void BlockUser()
        {
            if( Status == UserStatusEnum.Active && StatusBlock == StatusUserBlock.Unblock)
            {
                StatusBlock = StatusUserBlock.Block;
                BlockUntil = DateTime.Now.AddDays(30);
            }
        }

        public void InactivateUser()
        {
            if (Status == UserStatusEnum.Active)
            {
                Status = UserStatusEnum.Inactive;
            }
        }

        public void ActivateUser()
        {
            if (Status == UserStatusEnum.Inactive)
            {
                Status = UserStatusEnum.Active;
            }
        }

        public void UnblockUser()
        {
            if(Status != UserStatusEnum.Inactive && StatusBlock == StatusUserBlock.Block)
            {
                StatusBlock = StatusUserBlock.Unblock;
            }
        }
    }
}
