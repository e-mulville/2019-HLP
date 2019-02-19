type typeT = Immediate of string | Register of string | Instruction of string

type macroT = {
    Name: string;
    Parameters: typeT list;
    Body: string;
}



let expandMacro (call: string)(macroList: macroT list)= 
    //tokenise and extract the parameters
    let otherlist = ["$a";"$b"]
    let tokGen line = //This will turn a macro call into a list of tokens
        [ "Macro"; "R10"; "#0"]

    let macro = List.find ( fun a -> a["Name"] = "Steve")


    tokGen call
    |> function //make a list of only the paramaters
        | h::t -> t 
        | [] -> []
    |> List.zip otherlist
     //make pairs of the pattern to be replaced and the thing replacing it: this should check types
     //replace the content of the main from the macro using the list of pairs
     //return the completed string

expandMacro "aa"