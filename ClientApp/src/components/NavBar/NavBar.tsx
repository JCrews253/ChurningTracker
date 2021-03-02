import React from "react";
import { makeStyles, withStyles } from "@material-ui/core/styles";
import BottomNavigation from "@material-ui/core/BottomNavigation";
import BottomNavigationAction from "@material-ui/core/BottomNavigationAction";
import HomeIcon from "@material-ui/icons/Home";
import CreditCardIcon from "@material-ui/icons/CreditCard";
import AccountBalanceIcon from "@material-ui/icons/AccountBalance";
import PersonIcon from "@material-ui/icons/Person";
import { Link } from "react-router-dom";
import { ApplicationPaths } from "../api-authorization/ApiAuthorizationConstants";

const useStyles = makeStyles({
  root: {
    width: "100%",
    position: "fixed",
    bottom: 0,
    borderTop: "solid 1px gray",
  },
  actionItemStyles: {
    "&$selected": {
      color: "red",
      padding: "10px 10px 10px 10px",
    },
  },
  selected: {},
});

export const NavBar = () => {
  const classes = useStyles();
  const [value, setValue] = React.useState("home");

  const handleChange = (event: React.ChangeEvent<{}>, newValue: string) => {
    setValue(newValue);
  };

  return (
    <BottomNavigation
      value={value}
      onChange={handleChange}
      className={classes.root}
    >
      <BottomNavigationAction
        label="Home"
        value="home"
        icon={<HomeIcon />}
        component={Link}
        to="/"
      />
      <BottomNavigationAction
        label="Cards"
        value="creditCards"
        classes={{
          root: classes.actionItemStyles,
          selected: classes.selected,
        }}
        icon={<CreditCardIcon />}
        component={Link}
        to="/creditcards"
      />
      <BottomNavigationAction
        label="Banks"
        value="banks"
        icon={<AccountBalanceIcon />}
        component={Link}
        to="/"
      />
      <BottomNavigationAction
        label="Profile"
        value="profile"
        icon={<PersonIcon />}
        component={Link}
        to={ApplicationPaths.Profile}
      />
    </BottomNavigation>
  );
};

export default NavBar;
