public class SubsScript : MonoBehavior {

public GameObject textBox
public bool subDec = true;

void Update() {

    if (subDec == false) {
        textBox.SetActive(true);
        subDec = true;
    }
    else {
        textBox.SetActive(false);
        subDec = false;
    }
}
    void Start (){
        Debug.Log("Hello World");
    }
    
   IEnumerator TheSequence (){
        Debug.Log("Hello World");
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "Gosh, I'm so tired";
        yield return new WaitForSeconds(3);
       textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1.5);
        textBox.GetComponent<Text>().text= "I'm so tired";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "Yes, I'm so tired";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "No, I'm not";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "Test";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "SOn Goku";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "Kakarot";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "Piccolo";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "Vegeta";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text= "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text= "Kuririn";
    }
}

public void SwitchSubs ()
{
    if (subDec == false) {
        textBox.SetActive(true);
        subDec = true;
        return
    }
    if (subDec == true){
        textBox.SetActive(false);
        subDec = false;
        return;
    }

}