using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FreezarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        #region GET METHODS

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "recipes")]
        IList<Recipe> GetRecipes();

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "recipes/{id}")]
        Recipe GetRecipe(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "recipes/{id}/name")]
        string GetRecipeName(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "ingredient")]
        IList<Ingredient> GetIngredients();

        [OperationContract]
        [WebInvoke(Method = "GET",
             BodyStyle = WebMessageBodyStyle.Bare,
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "ingredients/{id}")]
        Ingredient GetIngredient(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "ingredients/{id}/name")]
        string GetIngredientName(string id);



        #endregion

        #region POST METHODS

        [OperationContract]
        [WebInvoke(Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "recipes/")]
        Recipe AddRecipe(Recipe recipe);

        [OperationContract]
        [WebInvoke(Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "ingreidents/")]
        Ingredient AddIngredient(Ingredient ingredient);

            #endregion

        #region PUT METHODS

        [OperationContract]
        [WebInvoke(Method = "PUT",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "recipe/{id}")]
        Recipe UpdateRecipe(string id, Recipe recipe);

        [OperationContract]
        [WebInvoke(Method = "PUT",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "ingredients/{id}")]
        Ingredient UpdateIngredient(string id, Ingredient ingredient);


            #endregion

        #region DELETE METHODS

        [OperationContract]
        [WebInvoke(Method = "DELETE",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "recipe/{id}")]
        Recipe DeleteRecipe(string id);

        [OperationContract]
        [WebInvoke(Method = "DELTE",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "ingredients/{id}")]
        Ingredient DeleteIngredient(string id);


        #endregion

    }
}
