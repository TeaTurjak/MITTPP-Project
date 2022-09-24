# MITTPP-Project
- This repository is used for the purpose of completing the designated Project task 2021/2022 which is the requirement for completing  the collage course Methods and Techniques of Software Testing at FERIT university
- To acomplish that 10 test cases were conducted on a chosen web site using Selenium testing

### Tested site           
----

[HCL](https://www.hcl.hr/ "HCL")

![](https://www.netokracija.com/wp-content/uploads/2012/02/hclhr_1naslovna.jpg)

- HCL Gaming Portal site was used for testing

### Necessary software to create and perform test cases            
----

[VisualStudio](https://visualstudio.microsoft.com/ "Visual Studio")

![](https://blog.devart.com/wp-content/uploads/2019/04/banner_BLOG_VS2019.png)
- Visual Studio 2019 was used to create testing project
-  NuGet packages necessary to perform test cases:
 - NUnit framework (3.13.2)
 - Nunit3 Test Adapter (4.1.0)
 - Selenium WebDriver (4.1.0)
 - Selenium WebDriver – Gecko Driver (0.30.0.1)
 - Selenium Support (4.1.0)

[KatalonRecorder](https://chrome.google.com/webstore/detail/katalon-recorder-selenium/ljdobmomdgdljniojadhoplhkpialdid "Katalon Recorder")

 ![](https://d1h3p5fzmizjvp.cloudfront.net/wp-content/uploads/2021/03/Katalon-Recorder-Chrome-Firefox-Edge.png)
- Katalon Recorder was used to create test cases because Katalon Recorder is a Selenium tests generator
- to use Katalon Recorder on Mozilla Firefox Browser it had to be installed as a browser extension

[MozillaFirefoxBrowser](https://www.mozilla.org/en-US/firefox/windows// "Mozilla Firefox Browser")

![](https://techrechard.com/wp-content/uploads/2022/02/firefox-logo.png)
- HCL Gaming website was tested on Mozilla Firefox Browser

### Setting up the project, creating and using test cases
                
----
- Using Visual Studio 2019 new Unit Test (.NET Framework) project was created using C#
- NuGet packeges were added to the project so that test cases could be used
- After that Katalon Recorder was used to create test cases on HCL website using Mozilla Firefox web browser
- To create the test cases user had to record the test case activity using Katalon Recorder
- That is done in a way in which user records all steps that they had taken on a web browser until the test case is complete
- Afterwards user tests the created test case
- If the test case was successfull, user can continue making other test cases
- After the test cases were successfully created and tested using Katalon Recorder, Katalon Recorder is used to export desired test cases in a C# (WebDriver + NUnit) format
- After the test cases are exported, they are added to the created project that was made using Visual Studio 2019 and the project is done

### Test cases
                
----
# Test case 1: LogInAndFromAccount
- before we created the test case, account was made on a website for the purpose of testing
 - user name: mittpptestiranje@gmail.com
 - user password: Y6mpAJ5VTkE5Ymc

|Step| Action                | Value                                      | Description                                                                                      
|:--:|:---------------------:|:------------------------------------------:|:-----------------------------------------------------------------:|
| 1  | navigate              | https://www.hcl.hr                         | user goes to the site for testing                                 |
| 2  | click                 | Prijavi se                                 | user presses "Prijavi se" button                                  |
| 3  | send keys             | mittpptestiranje@gmail.com                 | user enters user name                                             |
| 4  | send keys             | Y6mpAJ5VTkE5Ymc                            | user enters user email                                            |
| 5  | click                 | Prijava                                    | user logs in the account                                          |
| 6  | find element          | icon of user                               | user howers over user icon                                        |
| 7  | click                 | Odjavi se                                  | user logs out of the account by clicking the button "Odjavi se"   |


# Test case 2: AddAndRemoveGameFromCollection
- user is already logged in and on the HCL homepage

|Step| Action     | Value                 | Description                                                                                   |
|:--:|:----------:|:---------------------:|:---------------------------------------------------------------------------------------------:|
| 1  | click      | Igre                  | user clicks the tab "Igre"                                                                    |
| 2  | click      |  filter search        | user presses the filter search                                                                |
| 3  | send keys  | Star Wars             | user enters words to find the game                                                            |
| 4  | click      | quick filter submit   | user clicks the magnifying glass to start game search                                         |
| 5  | click      | add game              | user clicks on the desired game to put in the collection                                      |
| 6  | click      | Kolekcija             | user clicks on "Kolekcija" to get to the games in collection                                  |
| 7  | click      | Ukloni iz kolekcije   | user clicks "Ukloni iz kolekcije" at the game which they want to remove from collection       |

- user logs out from the account

# Test case 3: AddPCSpecificationsToProfile
- user is already logged in and on the HCL homepage

|Step| Action         | Value                  | Description                                |
|:--:|:--------------:|:----------------------:|:------------------------------------------:|
| 1  | find element   | icon of user           | user howers over user icon                 |
| 2  | click          |  Profile               | user clicks on "Profile"                   |
| 3  | click          | Uljepšaj svoj profil   | user clicks on "Uljepšaj svoj profil"      |
| 4  | send keys      | i5                     | user enters processor type                 | 
| 5  | send keys      | 5B20                   | user enters motherboard type               |
| 6  | send keys      | Nvidia                 | user enters GPU type                       |
| 7  | send keys      | 8                      | user enters RAM                            |
| 8  | send keys      | HD                     | user enters monitor type                   |
| 9  | send keys      | miš                    | user lists perifery                        |
| 10 | send keys      | slušalice              | user enters other data                     |
| 11 | click          | Spremi                 | user clicks on "Spremi" to save changes    |

- user logs out from the account

# Test case 4: FilterGames
- user is on the HCL homepage

|Step| Action  | Value                | Description                                                |
|:--:|:-------:|:--------------------:|:----------------------------------------------------------:|
| 1  | click   | Igre                 | user clicks the tab "Igre"                                 |
| 2  | click   |  filter platforms    | user clicks on the filter platforms search                 |
| 3  | select  | Switch               | user selects "Switch" from available options               |
| 4  | click   |  filter genre        | user clicks on the filter genre search                     |
| 5  | select  | Akcijska avantura    | user selects "Akcijska avantura" from available options    |
| 6  | click   |  developer           | user clicks on the developer search                        |
| 7  | select  | 38 Studios           | user selects "38 Studios" from available options           |
| 8  | click   |  publisher           | user clicks on the publisher search                        |
| 9  | select  | 11 bit Studios       | user selects "11 bit Studios" from available options       |
| 8  | click   |  Filtriraj           | user clicks on "Filtriraj" to start the search             |

# Test case 5: FindPost
- user is on the HCL homepage

|Step| Action  | Value                                        | Description                                             |
|:--:|:-------:|:--------------------------------------------:|:-------------------------------------------------------:|
| 1  | click   | Vijesti                                      | user clicks the tab "Vijesti"                           |
| 2  | click   |  filter search                               | user clicks on the filter search                        |
| 3  |send keys| Star Wars The Old Republic                   | user enters "Star Wars The Old Republic" in a search bar|
| 4  | click   |  quick filter submit                         | user clicks on the magnifying glass icon to start search|
| 5  | click   | Recenzija Star Wars: The Old Republic        | user clicks on the post to view                         |


# Test case 6: SearchGames
- user is on the HCL homepage

|Step| Action   | Value          |  Description                                                    |
|:--:|:--------:|:--------------:|:---------------------------------------------------------------:|
| 1  | click    |  Igre          | user clicks the tab "Igre"                                      |
| 2  | click    |  filter search | user clicks on the filter search                                |
| 3  | send keys| Alien          | user enters "Alien" to search all games with that word in a name|

# Test case 7: AddProductToShoppingCart
- user is on the HCL homepage

|Step| Action| Value            | Description                                                                   |
|:--:|:-----:|:----------------:|:-----------------------------------------------------------------------------:|
| 1  | click | HCL Shop         | user clicks the tab "HCL Shop"                                                |
| 2  | click |  chosen product  | user clicks on product to chose                                               |
| 3  | click | Odaberi opciju   | user clicks on "Odaberi opciju" to select product size (if clothes are chosen)|
| 4  | click | XS               | user clicks on the clothes size                                               |
| 5  | click | Dodaj u košaricu | user clicks on "Dodaj u košaricu" to add product to shopping cart             |


# Test case 8: AddMultipleProducts 
- user already has one product in a shopping cart

|Step| Action| Value             | Description                                              |
|:--:|:-----:|:-----------------:|:--------------------------------------------------------:|
| 1  | click | Continue shopping | user clicks the "Continue shopping" to add more products |


- steps from test case 7 are followed again from 2

# Test case 9: LowerNumberOfTheSameProductInACart 

- user already has multyple products of a same type in a shopping cart

|Step| Action| Value   | Description                                                                                         |
|:--:|:-----:|:-------:|:---------------------------------------------------------------------------------------------------:|
| 1  | click | Košarica| user clicks on "Košarica" to view products                                                          |
| 2  | click | -       | user clicks on "-" to lower a number of ordered products of an item that had a number bigger than 1 |


# Test case 10: RemoveProductFromShoppingCart

- user already has products in a shopping cart

|Step| Action| Value   | Description                                                                    |
|:--:|:-----:|:-------:|:------------------------------------------------------------------------------:|
| 1  | click | Košarica| user clicks on "Košarica" to view products                                     |
| 2  | click | x       | user clicks on "x" to remove a type of product completely from a shopping cart |


