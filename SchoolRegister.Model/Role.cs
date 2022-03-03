using Microsoft.AspNetCore.Identity;
public class Role: IdentityRole<int>{
    public RoleValue RoleValue {get;set;}
    public Role():base(){}
    public Role(string name, RoleValue roleValue):base(){
        this.Name = name;
        this.RoleValue = roleValue;
    }
}