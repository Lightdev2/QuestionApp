<template>
  <div class="nav">
    <div class="nav__content">
      <div class="nav__left">
        <logo class="nav__logo nav__logo--full" />
        <short-logo class="nav__logo nav__logo--short"></short-logo>
      </div>
      <top-search-input />
      <div class="nav__right">
        <div class="nav__right-item nav__user" v-if="isLoggedIn">
          <avatar />
          <span title="reputation" class="nav__rep">1</span>
        </div>
        <div title="achievements" class="nav__right-item nav__icon">
          <cup-icon />
        </div>
        <div title="notifications" class="nav__right-item nav__icon">
          <inbox-icon />
        </div>
        <div class="nav__controls">
          <primary-button class="nav__control">
            <template #label> Sign Ip </template>
          </primary-button>
          <primary-button class="nav__control">
            <template #label> Sign Ip </template>
          </primary-button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import TopSearchInput from "@/components/TopSearchInput";
import Avatar from "@/components/Avatar";
import Logo from "@/assets/logo";
import CupIcon from "@/assets/cup";
import InboxIcon from "@/assets/inbox";
import ShortLogo from "@/assets/short-logo";
import PrimaryButton from "./PrimaryButton.vue";

export default {
  name: "TopAppNav",
  components: {
    Avatar,
    TopSearchInput,
    Logo,
    CupIcon,
    InboxIcon,
    ShortLogo,
    PrimaryButton,
  },
};
</script>

<script setup>
const isLoggedIn = false;
</script>

<style scoped lang="scss">
.nav {
  position: fixed;
  width: 100%;
  background: var(--black25);
  padding: 0 10px;
  z-index: 9999;

  &__content {
    max-width: 1264px;
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin: 0 auto;
  }

  &__left {
    margin-right: 50px;
    @media screen and (max-width: 600px) {
      margin-right: 0;
    }
  }

  &__right {
    display: flex;
    align-items: center;
    margin-left: 50px;

    @media screen and (max-width: 760px) {
      margin-left: 0;
    }
  }

  &__right-item {
    fill: var(--black400);
    cursor: pointer;
    display: flex;
    align-items: center;
    height: 50px;
    &:hover {
      background-color: var(--black75);
    }
    &:not(:last-child) {
      margin-right: 1rem;
    }
  }

  &__icon {
    padding-left: 10px;
    padding-right: 10px;
  }

  &__logo {
    height: 35px;
    display: none;
    &--full {
      @media screen and (min-width: 600px) {
        display: block;
      }
    }
    &--short {
      @media screen and (max-width: 600px) {
        display: block;
        height: 25px;
        width: 25px;
        margin-right: 5px;
      }
    }
  }

  &__user {
    display: flex;
    align-items: center;
    cursor: pointer;
    height: 50px;
    padding-left: 1rem;
    padding-right: 1rem;
    &:hover {
      background-color: var(--black75);
    }
  }
  &__rep {
    color: var(--black900);
    margin-left: 1rem;
  }

  &__controls {
    display: flex;
    align-items: center;
  }
  &__control {
    white-space: nowrap;
    &:first-child {
      margin-right: 1rem;
    }
  }
}
</style>
