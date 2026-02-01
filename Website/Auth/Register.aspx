<%@ Page Language="C#" MasterPageFile="../MasterPage.Master" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Register</h1>
<label>Username</label><br />
<input><br />
<label>Password</label><br />
<input><br />
<label>Verify Password</label><br />
<input><br />
<label>First Name</label><br />
<input><br />
<label>Second Name</label><br />
<input><br />
<label>City</label><br />
<input><br />
<label>Phone</label><br />
<input type="tel"><br />
<label>Email</label><br />
<input type="email"><br />
<label>Gender</label><br />
<input type="radio" name="gender" value="Male">Male<br />
<input type="radio" name="gender" value="Female">Female<br />
<label>Password Restore Questions</label><br />
<select multiple>
<option value="Cat's Name">Cat's Name</option>
<option value="Grandma's Name">Grandma's Name</option>
<option value="Mom's Name">Mom's Name</option>
<option value="Dad's Name">Dad's Name</option>
</select><br />
<input><br />
<input><br />
<input type="submit">
<input type="reset">
</asp:Content>
