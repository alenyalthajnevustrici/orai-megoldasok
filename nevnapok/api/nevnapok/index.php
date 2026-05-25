<?php

header("Content-Type: application/json; charset=utf-8");

header("Access-Control-Allow-Origin: *");

$kapcsolat = mysqli_connect(
    "localhost",
    "root",
    "",
    "nevnapok"
);

if(!$kapcsolat){

    echo json_encode([
        "hiba" => "adatbazis hiba"
    ]);

    exit;
}

mysqli_set_charset($kapcsolat,"utf8");

$honapok = [

    1 => "január",
    2 => "február",
    3 => "március",
    4 => "április",
    5 => "május",
    6 => "június",
    7 => "július",
    8 => "augusztus",
    9 => "szeptember",
    10 => "október",
    11 => "november",
    12 => "december"

];

if(isset($_GET["nap"])){

    $datum = $_GET["nap"];

    $darabok = explode("-", $datum);

    if(count($darabok) != 2){

        echo json_encode([
            "hiba" => "nincs találat"
        ]);

        exit;
    }

    $ho = intval($darabok[0]);

    $nap = intval($darabok[1]);

    $sql = "
    
    SELECT *
    
    FROM nevnap
    
    WHERE ho = $ho
    
    AND nap = $nap
    
    ";

    $eredmeny = mysqli_query($kapcsolat,$sql);

    if(mysqli_num_rows($eredmeny) > 0){

        $sor = mysqli_fetch_assoc($eredmeny);

        echo json_encode([

            "datum" =>
            $honapok[$sor["ho"]] .
            " " .
            $sor["nap"] .
            ".",

            "nevnap1" => $sor["nev1"],

            "nevnap2" => $sor["nev2"]

        ], JSON_UNESCAPED_UNICODE);

    }
    else{

        echo json_encode([

            "hiba" => "nincs találat"

        ], JSON_UNESCAPED_UNICODE);

    }

    exit;

}

if(isset($_GET["nev"])){

    $nev = mysqli_real_escape_string(
        $kapcsolat,
        $_GET["nev"]
    );

    $sql = "
    
    SELECT *
    
    FROM nevnap
    
    WHERE nev1 = '$nev'
    
    OR nev2 = '$nev'
    
    LIMIT 1
    
    ";

    $eredmeny = mysqli_query($kapcsolat,$sql);

    if(mysqli_num_rows($eredmeny) > 0){

        $sor = mysqli_fetch_assoc($eredmeny);

        echo json_encode([

            "datum" =>
            $honapok[$sor["ho"]] .
            " " .
            $sor["nap"] .
            ".",

            "nevnap1" => $sor["nev1"],

            "nevnap2" => $sor["nev2"]

        ], JSON_UNESCAPED_UNICODE);

    }
    else{

        echo json_encode([

            "hiba" => "nincs találat"

        ], JSON_UNESCAPED_UNICODE);

    }

    exit;

}

echo json_encode([

    "minta1" => "/?nap=12-31",

    "minta2" => "/?nev=Katalin"

], JSON_UNESCAPED_UNICODE);

?>