// 1. javascript was designed to add interactivity to HTML pages
// 2. JavaScript is a scripting language
// 3. A scripting language is a lightweight programming language
// 4. JavaScript is usually embedded directly into HTML pages
// 5. JavaScript is an interpreted language (means the scripts execure withour preliminary compilation)
// 6. Everyone can use JavaScript without purchasing a license

//#region Exercise - 1.1 Math Functions

function tableStart() {
    document.write("<table>");
}
function tableEnd() {
    documment.write("</table>");
}
function displayResults(description, valueX, valueY) {
    document.write("<tr><td width='100px'>");
    document.write(description);
    document.write("</td><td width = '100px'>");
    document.write(valueX);
    document.write("</td><td width='100px'>");
    document.write(valueY);
    document.write("</td></tr>");
}
function math01() {
    tableStart();
    displayResults("Formula", "X", "Y");
    var x = 0;
    var y = 5;

    //x = y+2;   Addition
    //displayResults("x=y+2", x, y);

    //x = y-2;		Substruction
    //displayResults("x=y-2", x, y);

    //x = y*2;		Multiplication
    //displayResults("x=x*2", x, y);

    //x = y/2;		Division
    //displayResults("x = y/2", x, y);

    //x = y%2;		Modulo
    //displayResults("x=y%2", x, y);

    //x = ++y;		// pre-increment
    //displayResults("x = ++y", x, y);

    //x = y++;		// post-increment
    //displayResults("x = y++", x, y);

    //x = --y;      // pre-decrement
    //displayResults("x = --y", x, y);

    x = y--;        // post-decrement
    displayResults("x = y--", x, y);

    tableEnd();
}
//#endregion Math Functions

function TryIt() {
    //math01();    
    //ConfirmationAndAlertPopupDialog()
    //PromptPopupDialog();
}

// #region Exercise 1.2 Pop-up Dialogs
function ConfirmationAndAlertPopupDialog()
{
    // It shows pop-up with two buttons OK and Cancel
    var r = confirm("Press a button");

    if (r == true) {
        // Pop-ups with OK button only
        alert("You pressed OK!");
    }
    else
    {
        alert("You pressed Cancel!");
    }
}
function PromptPopupDialog()
{
    // Popup with textbox along with OK and Cancel button (Note: Textbox will filled with "Suresh Kaushik" otherwise it textbox will be blank)
    var name = prompt("Please enter yourname", "Suresh Kaushik");
    alert("You entered: " + name);
}
// #endregion Exercise 1.2 Pop-up Dialogs

// #region Exercise 1.3
