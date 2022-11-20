module Bob

let response (input: string): string =
    match input with
    | "How are you?" -> "Sure"
    | "YELL AT HIM" -> "Whoa, chill out!"