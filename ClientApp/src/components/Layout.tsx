import { Container } from "@material-ui/core";
import React, { ReactNode } from "react";
import { NavBar } from "./NavBar/NavBar";

export interface LayoutProps {
  children: ReactNode;
}

export const Layout = ({ children }: LayoutProps) => {
  return (
    <div>
      {children}
      <NavBar />
    </div>
  );
};
