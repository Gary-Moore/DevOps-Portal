provider "azurerm" {
  
}


resource "azurerm_resource_group" "devops_portal" {
  name = "gw-devops-portal-rg"
  location = "West Europe"

  tags = {
      product = "devops portal",
      organisation = "GammaWeb Solutions"
  }
}
