import { makeStyles } from "@material-ui/core";
import React from "react";
import AmexGold from "../../Images/CreditCards/AmexGold.webp";
const styles = makeStyles({
  root: {
    width: "300px",
    border: "solid 1px gray",
    backgroundImage: `url(${AmexGold})`,
    backgroundSize: "auto 100%",
    backgroundRepeat: "no-repeat",
    backgroundPosition: "center center",
  },
});

export interface ICreditCard {
  Name?: string;
  Bank?: string;
}

export const CreditCard = ({ Name, Bank }: ICreditCard) => {
  const classes = styles();
  return (
    <div className={classes.root}>
      <h1>{Name}</h1>
      <h1>{Bank}</h1>
    </div>
  );
};

export default CreditCard;
