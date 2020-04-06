var itemDesc = new Array(10000);
var itemCost = new Array(10000);
var itemQuan = new Array(10000);
var itemAmnt = new Array(10000);

var text;
var fileLength;

//Function to read textfile
function readTextFile(file)
{
    var rawFile = new XMLHttpRequest();
    rawFile.open("GET", file, false);
    rawFile.onreadystatechange = function ()
    {
        if(rawFile.readyState === 4)
        {
            if(rawFile.status === 200 || rawFile.status == 0)
            {
                text = rawFile.responseText;
            }
        }
    }
    rawFile.send(null);
}

//generates Table Heading, and generates rows, and total area
function generateTable()
{
    readTextFile("file:///C:/Users/Public/MDCdevice/PrintFile/read.txt")
    var lines = text.split("\n");

    fileLength = lines.length;

    for(i=0; i<lines.length;i++)
    {
        if(i == 0)
        {
            var line = lines[i].split("*");
            document.getElementById("companyName").value = line[0];
            document.getElementById("Date").value = line[1];
        }
        else
        {
            var line = lines[i].split("*");

            itemDesc[i] = line[0];
            itemCost[i] = line[1];
            itemQuan[i] = line[2];
            itemAmnt[i] = line[3];
        }
    }

    document.write("<div class='row'>");
        document.write("<div> Particular    </div>");
        document.write("<div> Item Cost     </div>");
        document.write("<div> Quantity      </div>");
        document.write("<div> Amount        </div>");
        
        for(i=1; i<fileLength; i++)
        {
            generateRow(i.toString());
        }

    document.write("</div>");

    document.write("<br></br>");
    document.write("<div> Total: <input id='total' type='number'/> </div>");
    
}

function generateRow(index)
{
    document.write("<div> <input id='Item"+ index +"'              /> </div>");
    document.write("<div> <input id='Cost"+ index +"' type='number'/> </div>");
    document.write("<div> <input id='Quan"+ index +"' type='number'/> </div>");
    document.write("<div> <input id='Amnt"+ index +"' type='number'/> </div>");
}

//math thing
function generateTotal()
{
    sum = 0;
    for(i=1; i<fileLength; i++) 
    { 
        var integer = parseFloat(itemAmnt[i]);
        sum+= integer; 
    }
    document.getElementById("total").value = sum;
}

//fill table with content from arrays
function fillTable()
{
    for(x=1; x<fileLength; x++)
    {
        var integer = parseFloat(itemAmnt[x]);

        document.getElementById("Item" + x).value = itemDesc[x];
        document.getElementById("Cost" + x).value = itemCost[x];
        document.getElementById("Quan" + x).value = itemQuan[x];
        document.getElementById("Amnt" + x).value = integer;
    }
}    

generateTable();
fillTable();
generateTotal();