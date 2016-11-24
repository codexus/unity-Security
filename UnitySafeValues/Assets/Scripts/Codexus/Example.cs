using UnityEngine;
using Codexus.Security;
using System.Collections;

public class Example : MonoBehaviour {

	void Start () {

        // FLOAT

        // create a new security float with value 50
        SecuredFloat securityfloat1 = new SecuredFloat(50);
        // create a new security float with value 50
        SecuredFloat securityfloat2 = new SecuredFloat(50);

        // Check if is Equal
        Debug.Log(securityfloat1.Equals(securityfloat2));
        // Check hashes
        Debug.Log(securityfloat1.GetHashCode() + " / " + securityfloat2.GetHashCode());
        // Assert that value should be 0
        Debug.Log(securityfloat1 - securityfloat2);


        // INT

        // create a new security float with value 50
        SecuredInt securedInt1 = new SecuredInt(50);
        // create a new security float with value 50
        SecuredInt securedInt2 = new SecuredInt(50);

        // Check if is Equal
        Debug.Log(securedInt1.Equals(securedInt2));
        // Check hashes
        Debug.Log(securedInt1.GetHashCode() + " / " + securedInt2.GetHashCode());
        // Assert that value should be 0
        Debug.Log(securedInt1 - securedInt2);

    }
}
